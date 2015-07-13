using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LinqToExcel;
using System.Data.OleDb;
namespace EtrendImport
{
    public partial class Form1 : Form
    {
        int cust_sn = 0; 
        OpenFileDialog OD = new OpenFileDialog();
        string xlsFilterString = "Excel File (*.xls)|*.xls";
        string dbfFilterString = "DBC File (*.dbc)|*.dbc";
        string dbfConnectionString = "Provider=VFPOLEDB.1;Data Source={0};";
        string mappingShtNane = string.Empty;
        System.Data.OleDb.OleDbConnection dbfCN = null;
        System.Data.OleDb.OleDbCommand dbfCMD = null;
        public Form1()
        {
            InitializeComponent();
        }

        protected void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected void btnTransfer(object sender, EventArgs e)
        {
            lstError.Items.Clear();
            importToEntrend();
        }

        protected void importToEntrend()
        {
            if (!myValidate())
                return;
            string[] mappingList = {"CustMapping","FrglbrMapping" };
            string[] sourceList = { txtSource.Text, txtFrglbr.Text };
            string[] sourceShtList = { cboCust.SelectedItem.ToString(), cboFrglbr.SelectedItem.ToString() };
            string[] dbfNameList = { "cust", "frglbr" };
            string[] frgchkValues = { "", "", "", "" };
            string sql;

            dbfCN = new System.Data.OleDb.OleDbConnection(
                string.Format(dbfConnectionString, txtTarget.Text));
            dbfCN.Open();
            dbfCMD = dbfCN.CreateCommand();
            //clearDBF(dbfNameList[i]);
            clearDBF(dbfNameList);

            var mapExcel = new ExcelQueryFactory(txtMapping.Text);
            var mappingFrgchkSht = from c in mapExcel.Worksheet<mapping>("FrgchkMapping")
                                   where !string.IsNullOrEmpty(c.new_name)
                                   select c;
            StringBuilder fieldSB = new StringBuilder();
            StringBuilder valueSB = new StringBuilder();
            StringBuilder frgchkSB = new StringBuilder();
            for (int i = 0; i < mappingList.Length; i++)
            {
                var excel = new ExcelQueryFactory(sourceList[i]);
                var sourceSht = from s in excel.Worksheet(sourceShtList[i])
                                select s;

                var mappingSht = from c in mapExcel.Worksheet<mapping>(mappingList[i])
                                 where !string.IsNullOrEmpty(c.new_name)
                                 select c;
                cust_sn = 0;
                //dbfCMD = dbfCN.CreateCommand();
                //clearDBF(dbfNameList[i]);
                foreach (var itemRow in sourceSht)
                {
                    if (string.IsNullOrEmpty(itemRow[0].ToString()))
                        break;
                    cust_sn++;
                    #region foreach (mapping mpRow in mappingSht)
                    foreach (mapping mpRow in mappingSht)
                    {
                        fieldSB.AppendFormat(",{0}", mpRow.e_name);
                        valueSB.AppendFormat(",{0}", getNewValue(mpRow, itemRow));
                    }
                    sql = string.Format(@"INSERT INTO {0}({1}) VALUES({2})", dbfNameList[i]
                        , fieldSB.ToString().Substring(1)
                        , valueSB.ToString().Substring(1));
                    fieldSB.Clear();
                    valueSB.Clear();
                    try
                    {
                        dbfCMD.CommandType = CommandType.Text;
                        dbfCMD.CommandText = sql;
                        dbfCMD.ExecuteNonQuery();
                        Application.DoEvents();
                        //新增frgchk
                        if (mappingList[i] == "FrglbrMapping")
                        {
                           
                            frgchkSB.Clear();
                            frgchkSB.AppendFormat(",{0}", itemRow[0].ToString());
                            foreach (mapping mpRow in mappingFrgchkSht)
                            {
                                frgchkSB.AppendFormat(",{0}", getNewValue(mpRow, itemRow));
                            }                                                        
                            insertIntoFrgchk(
                                frgchkSB.ToString().Substring(1).Split(new char[]{','}));
                        }
                    }
                    catch (Exception ex)
                    {
                        //System.Diagnostics.Debugger.Break();
                        lstError.Items.Add(string.Format("{0}:{1}", itemRow[0].ToString(),ex.Message));
                    }
                    #endregion
                }
            }
            dbfCN.Close();
            dbfCN.Dispose();
            MessageBox.Show("完成");
        }

        protected void insertIntoFrgchk(string[] p_values)
        {
            string sql =mapping.GetFRGCHKSql(p_values);
            dbfCMD.Parameters.Clear();
            dbfCMD.CommandType = CommandType.StoredProcedure;
            dbfCMD.CommandText = "ExecScript";
            dbfCMD.Parameters.Add("frgchkScript"
                , OleDbType.Char).Value = sql;
            dbfCMD.ExecuteNonQuery();
        }

        protected void clearDBF(string[] p_dbf)
        //protected void clearDBF(string p_dbf)
        {
            foreach (string dbf in p_dbf)
            {
                string sql = string.Format(@"set exclusive on
                                    delete from {0}
                                    pack ", dbf);
                dbfCMD.CommandType = CommandType.StoredProcedure;
                dbfCMD.CommandText = "ExecScript";
                dbfCMD.Parameters.Add("myScript", OleDbType.Char).Value = sql;
                dbfCMD.ExecuteNonQuery();
                dbfCMD.Parameters.Clear();
            }
        }

        protected string getNewValue(mapping p_mapp,LinqToExcel.Row p_row)
        {
            string new_value = string.Empty;
            if (!p_mapp.new_name.Equals("DEFAULT"))
            {
                switch (p_mapp.new_name)
                {
                    case "性別":
                        new_value = p_row[p_mapp.new_name] == "女" ? "'F'" : "'M'";
                        break;
                    case "生日":
                    case "入境日":
                    case "護照期限":
                    case "聘可期限":
                    case "居留期限":
                        if (p_row[p_mapp.new_name].Value == DBNull.Value)
                        {
                            new_value = "{^//}";
                        }
                        else
                        {
                            new_value = "{^" + Convert.ToDateTime(p_row[p_mapp.new_name]).ToShortDateString() + "}";
                        }                        
                        break;
                    case "外勞狀態":
                        new_value = "1";
                        break;
                    default:
                        new_value = string.Format("'{0}'"
                            , p_row[p_mapp.new_name] == null ? string.Empty : p_row[p_mapp.new_name]);
                        break;
                }
            }
            else
            {
                if (p_mapp.e_name.Equals("CUST_SN") || p_mapp.e_name.Equals("LBR_SN"))
                {
                    new_value = cust_sn.ToString();                
                }
                else
                {
                    switch (p_mapp.field_type.ToUpper())
                    {
                        case "L":
                            new_value = ".t.";
                            break;
                        case "C":
                            new_value = "''";
                            break;
                        case "D":
                        case "T":
                            new_value = "{^//}";
                            break;
                        case "I":
                        case "N":
                        case "Y":
                            new_value = "0";
                            break;
                    }                
                }
            }
            return new_value;
        }

        protected void myOpenFileDialog(TextBox p_textBox, string p_filter)
        {
            setOpenFileDialog(p_filter);
            if (OD.ShowDialog() == DialogResult.OK)
            {
                p_textBox.Text = OD.FileName;
            }
        }

        protected void getExclSheets(TextBox p_textBox,ComboBox p_cbo)
        {
            if (string.IsNullOrEmpty(p_textBox.Text))
                return;
            var excel = new ExcelQueryFactory(p_textBox.Text);
            IEnumerable<string> sheets = excel.GetWorksheetNames();
            foreach (string sht in sheets)
            {
                p_cbo.Items.Add(sht);
            }
        }

        private void btnOpenSource_Click(object sender, EventArgs e)
        {
            myOpenFileDialog(txtSource,xlsFilterString);
            getExclSheets(txtSource, cboCust);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            myOpenFileDialog(txtTarget,dbfFilterString);
        }

        protected void setOpenFileDialog(string p_filter)
        {
            OD.InitialDirectory = "c:\\";
            OD.Filter = p_filter;
            OD.FilterIndex = 2;
            OD.RestoreDirectory = true;
        }

        private void btnFrglbr_Click(object sender, EventArgs e)
        {
            myOpenFileDialog(txtFrglbr, xlsFilterString);
            getExclSheets(txtFrglbr, cboFrglbr);
        }

        private void btnMapping_Click(object sender, EventArgs e)
        {
            myOpenFileDialog(txtMapping, xlsFilterString);
        }

        protected bool myValidate()
        {
            bool ok = true;
            Control[] txtCollect = {txtSource,txtFrglbr,txtMapping,txtTarget};
            //檢查是否有選擇來源檔
            foreach (TextBox tb in txtCollect)
            {
                if (string.IsNullOrEmpty(tb.Text))
                {
                    ok = false;
                    MessageBox.Show("請碓認是否已選擇檔案來源");
                    tb.Focus();
                    break;
                }                
            }
            if (ok.Equals(true))
            {
                Control[] cboCollect = { cboCust, cboFrglbr };
                foreach (ComboBox cb in cboCollect)
                {
                    if (cb.SelectedItem == null)
                    {
                        ok = false;
                        MessageBox.Show("請碓認是否已選擇工作表");
                        cb.Focus();
                        break;
                    }
                }            
            }
            return ok;
        }
    }
}
