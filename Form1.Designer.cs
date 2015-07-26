namespace EtrendImport
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnOpenSource = new System.Windows.Forms.Button();
            this.btnDBF = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTrans = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstError = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFrglbr = new System.Windows.Forms.TextBox();
            this.btnFrglbr = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cboCust = new System.Windows.Forms.ComboBox();
            this.cboFrglbr = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMapping = new System.Windows.Forms.TextBox();
            this.btnMapping = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "客戶檔案來源(EXCEL)";
            // 
            // txtSource
            // 
            this.txtSource.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSource.Location = new System.Drawing.Point(9, 27);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(400, 27);
            this.txtSource.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "目的地(DATA)";
            // 
            // txtTarget
            // 
            this.txtTarget.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTarget.Location = new System.Drawing.Point(9, 197);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(603, 27);
            this.txtTarget.TabIndex = 3;
            this.txtTarget.Text = "D:\\ForBox2\\Etrend\\FManager\\DATA_0421\\people.dbc";
            // 
            // btnOpenSource
            // 
            this.btnOpenSource.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSource.Location = new System.Drawing.Point(415, 27);
            this.btnOpenSource.Name = "btnOpenSource";
            this.btnOpenSource.Size = new System.Drawing.Size(36, 25);
            this.btnOpenSource.TabIndex = 4;
            this.btnOpenSource.Text = "...";
            this.btnOpenSource.UseVisualStyleBackColor = true;
            this.btnOpenSource.Click += new System.EventHandler(this.btnOpenSource_Click);
            // 
            // btnDBF
            // 
            this.btnDBF.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDBF.Location = new System.Drawing.Point(621, 197);
            this.btnDBF.Name = "btnDBF";
            this.btnDBF.Size = new System.Drawing.Size(36, 25);
            this.btnDBF.TabIndex = 5;
            this.btnDBF.Text = "...";
            this.btnDBF.UseVisualStyleBackColor = true;
            this.btnDBF.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(556, 332);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 43);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTrans
            // 
            this.btnTrans.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrans.Location = new System.Drawing.Point(449, 332);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(101, 43);
            this.btnTrans.TabIndex = 7;
            this.btnTrans.Text = "轉檔";
            this.btnTrans.UseVisualStyleBackColor = true;
            this.btnTrans.Click += new System.EventHandler(this.btnTransfer);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(453, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "選擇要匯入客戶工作表";
            // 
            // lstError
            // 
            this.lstError.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstError.FormattingEnabled = true;
            this.lstError.ItemHeight = 19;
            this.lstError.Location = new System.Drawing.Point(9, 257);
            this.lstError.Name = "lstError";
            this.lstError.Size = new System.Drawing.Size(434, 118);
            this.lstError.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "錯誤";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "外勞檔案來源(EXCEL)";
            // 
            // txtFrglbr
            // 
            this.txtFrglbr.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrglbr.Location = new System.Drawing.Point(9, 81);
            this.txtFrglbr.Name = "txtFrglbr";
            this.txtFrglbr.Size = new System.Drawing.Size(400, 27);
            this.txtFrglbr.TabIndex = 16;
            // 
            // btnFrglbr
            // 
            this.btnFrglbr.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFrglbr.Location = new System.Drawing.Point(415, 83);
            this.btnFrglbr.Name = "btnFrglbr";
            this.btnFrglbr.Size = new System.Drawing.Size(36, 25);
            this.btnFrglbr.TabIndex = 17;
            this.btnFrglbr.Text = "...";
            this.btnFrglbr.UseVisualStyleBackColor = true;
            this.btnFrglbr.Click += new System.EventHandler(this.btnFrglbr_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(457, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "選擇要匯入外勞工作表";
            // 
            // cboCust
            // 
            this.cboCust.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCust.FormattingEnabled = true;
            this.cboCust.Location = new System.Drawing.Point(457, 27);
            this.cboCust.Name = "cboCust";
            this.cboCust.Size = new System.Drawing.Size(200, 27);
            this.cboCust.TabIndex = 19;
            // 
            // cboFrglbr
            // 
            this.cboFrglbr.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFrglbr.FormattingEnabled = true;
            this.cboFrglbr.Location = new System.Drawing.Point(457, 83);
            this.cboFrglbr.Name = "cboFrglbr";
            this.cboFrglbr.Size = new System.Drawing.Size(200, 27);
            this.cboFrglbr.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Etrend 欄位來源(EXCEL)";
            // 
            // txtMapping
            // 
            this.txtMapping.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMapping.Location = new System.Drawing.Point(9, 142);
            this.txtMapping.Name = "txtMapping";
            this.txtMapping.Size = new System.Drawing.Size(606, 27);
            this.txtMapping.TabIndex = 26;
            this.txtMapping.Text = "D:\\ForBox2\\To Saint\\20150725\\EtrendMapping.xls";
            // 
            // btnMapping
            // 
            this.btnMapping.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMapping.Location = new System.Drawing.Point(621, 142);
            this.btnMapping.Name = "btnMapping";
            this.btnMapping.Size = new System.Drawing.Size(36, 25);
            this.btnMapping.TabIndex = 27;
            this.btnMapping.Text = "...";
            this.btnMapping.UseVisualStyleBackColor = true;
            this.btnMapping.Click += new System.EventHandler(this.btnMapping_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 386);
            this.Controls.Add(this.btnMapping);
            this.Controls.Add(this.txtMapping);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cboFrglbr);
            this.Controls.Add(this.cboCust);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFrglbr);
            this.Controls.Add(this.txtFrglbr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTrans);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDBF);
            this.Controls.Add(this.btnOpenSource);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Etrend Import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnOpenSource;
        private System.Windows.Forms.Button btnDBF;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstError;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFrglbr;
        private System.Windows.Forms.Button btnFrglbr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboCust;
        private System.Windows.Forms.ComboBox cboFrglbr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMapping;
        private System.Windows.Forms.Button btnMapping;
    }
}

