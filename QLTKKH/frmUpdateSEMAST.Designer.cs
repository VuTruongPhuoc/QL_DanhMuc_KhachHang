namespace QLTKKH
{
    partial class frmUpdateSEMAST
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
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpLASTDATE = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpCLSDATE = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpOPNDATE = new System.Windows.Forms.DateTimePicker();
            this.btnACCTNO = new System.Windows.Forms.Button();
            this.cboCODEID = new System.Windows.Forms.ComboBox();
            this.txtTOTALBUYAMT = new System.Windows.Forms.TextBox();
            this.txtACCTNO = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboAFACCTNO = new System.Windows.Forms.ComboBox();
            this.lbCUSTODYCD = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTaiSanCK = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(805, 515);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 37);
            this.btnExit.TabIndex = 33;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpLASTDATE);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpCLSDATE);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpOPNDATE);
            this.groupBox1.Controls.Add(this.btnACCTNO);
            this.groupBox1.Controls.Add(this.cboCODEID);
            this.groupBox1.Controls.Add(this.txtTOTALBUYAMT);
            this.groupBox1.Controls.Add(this.txtACCTNO);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboAFACCTNO);
            this.groupBox1.Controls.Add(this.lbCUSTODYCD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1006, 406);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài sản CK KH";
            // 
            // dtpLASTDATE
            // 
            this.dtpLASTDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLASTDATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLASTDATE.Location = new System.Drawing.Point(736, 320);
            this.dtpLASTDATE.Name = "dtpLASTDATE";
            this.dtpLASTDATE.Size = new System.Drawing.Size(200, 30);
            this.dtpLASTDATE.TabIndex = 80;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(542, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 79;
            this.label2.Text = "Ngày GD cuối cùng:";
            // 
            // dtpCLSDATE
            // 
            this.dtpCLSDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCLSDATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCLSDATE.Location = new System.Drawing.Point(246, 320);
            this.dtpCLSDATE.Name = "dtpCLSDATE";
            this.dtpCLSDATE.Size = new System.Drawing.Size(208, 30);
            this.dtpCLSDATE.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 77;
            this.label1.Text = "Ngày đóng TK:";
            // 
            // dtpOPNDATE
            // 
            this.dtpOPNDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOPNDATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOPNDATE.Location = new System.Drawing.Point(736, 222);
            this.dtpOPNDATE.Name = "dtpOPNDATE";
            this.dtpOPNDATE.Size = new System.Drawing.Size(200, 30);
            this.dtpOPNDATE.TabIndex = 76;
            // 
            // btnACCTNO
            // 
            this.btnACCTNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnACCTNO.Location = new System.Drawing.Point(469, 118);
            this.btnACCTNO.Name = "btnACCTNO";
            this.btnACCTNO.Size = new System.Drawing.Size(41, 37);
            this.btnACCTNO.TabIndex = 75;
            this.btnACCTNO.Text = "....";
            this.btnACCTNO.UseVisualStyleBackColor = true;
            // 
            // cboCODEID
            // 
            this.cboCODEID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCODEID.FormattingEnabled = true;
            this.cboCODEID.Location = new System.Drawing.Point(736, 120);
            this.cboCODEID.Name = "cboCODEID";
            this.cboCODEID.Size = new System.Drawing.Size(200, 33);
            this.cboCODEID.TabIndex = 73;
            this.cboCODEID.SelectedIndexChanged += new System.EventHandler(this.cboCODEID_SelectedIndexChanged);
            // 
            // txtTOTALBUYAMT
            // 
            this.txtTOTALBUYAMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTOTALBUYAMT.Location = new System.Drawing.Point(246, 220);
            this.txtTOTALBUYAMT.Multiline = true;
            this.txtTOTALBUYAMT.Name = "txtTOTALBUYAMT";
            this.txtTOTALBUYAMT.Size = new System.Drawing.Size(208, 32);
            this.txtTOTALBUYAMT.TabIndex = 74;
            // 
            // txtACCTNO
            // 
            this.txtACCTNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtACCTNO.Location = new System.Drawing.Point(244, 120);
            this.txtACCTNO.Multiline = true;
            this.txtACCTNO.Name = "txtACCTNO";
            this.txtACCTNO.Size = new System.Drawing.Size(206, 35);
            this.txtACCTNO.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(542, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 71;
            this.label6.Text = "Ngày mở TK:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "Tổng số lượng CK:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(542, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 20);
            this.label4.TabIndex = 69;
            this.label4.Text = "ID Chứng khoán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 68;
            this.label3.Text = "Số tài khoản CK:";
            // 
            // cboAFACCTNO
            // 
            this.cboAFACCTNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAFACCTNO.FormattingEnabled = true;
            this.cboAFACCTNO.Location = new System.Drawing.Point(244, 32);
            this.cboAFACCTNO.Name = "cboAFACCTNO";
            this.cboAFACCTNO.Size = new System.Drawing.Size(210, 33);
            this.cboAFACCTNO.TabIndex = 52;
            this.cboAFACCTNO.SelectedIndexChanged += new System.EventHandler(this.cboAFACCTNO_SelectedIndexChanged);
            // 
            // lbCUSTODYCD
            // 
            this.lbCUSTODYCD.AutoSize = true;
            this.lbCUSTODYCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCUSTODYCD.Location = new System.Drawing.Point(73, 39);
            this.lbCUSTODYCD.Name = "lbCUSTODYCD";
            this.lbCUSTODYCD.Size = new System.Drawing.Size(117, 20);
            this.lbCUSTODYCD.TabIndex = 51;
            this.lbCUSTODYCD.Text = "Tài khoản GD:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(556, 515);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 37);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Chấp nhận";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lbTaiSanCK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 72);
            this.panel1.TabIndex = 30;
            // 
            // lbTaiSanCK
            // 
            this.lbTaiSanCK.AutoSize = true;
            this.lbTaiSanCK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTaiSanCK.Location = new System.Drawing.Point(3, 24);
            this.lbTaiSanCK.Name = "lbTaiSanCK";
            this.lbTaiSanCK.Size = new System.Drawing.Size(197, 20);
            this.lbTaiSanCK.TabIndex = 0;
            this.lbTaiSanCK.Text = "Thêm Mới Tài Sản CK.";
            // 
            // frmUpdateSEMAST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 605);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel1);
            this.Name = "frmUpdateSEMAST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateSEMAST";
            this.Load += new System.EventHandler(this.frmUpdateSEMAST_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTaiSanCK;
        private System.Windows.Forms.Label lbCUSTODYCD;
        private System.Windows.Forms.DateTimePicker dtpLASTDATE;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpCLSDATE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpOPNDATE;
        private System.Windows.Forms.Button btnACCTNO;
        private System.Windows.Forms.ComboBox cboCODEID;
        private System.Windows.Forms.TextBox txtTOTALBUYAMT;
        private System.Windows.Forms.TextBox txtACCTNO;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboAFACCTNO;
    }
}