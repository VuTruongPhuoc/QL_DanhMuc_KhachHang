namespace QLTKKH
{
    partial class frmSECURITIES_Account
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
            this.grbKhachHang = new System.Windows.Forms.GroupBox();
            this.dgvSEAccount = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPP = new System.Windows.Forms.Label();
            this.lbDEPOFEEAMT = new System.Windows.Forms.Label();
            this.lbBALANCE = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.AFACCTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYMBOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALBUYAMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LASTDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSEAccount)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbKhachHang
            // 
            this.grbKhachHang.Controls.Add(this.dgvSEAccount);
            this.grbKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbKhachHang.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.grbKhachHang.Location = new System.Drawing.Point(0, 148);
            this.grbKhachHang.Name = "grbKhachHang";
            this.grbKhachHang.Size = new System.Drawing.Size(894, 355);
            this.grbKhachHang.TabIndex = 10;
            this.grbKhachHang.TabStop = false;
            this.grbKhachHang.Text = "Danh sách tài khoản CK";
            // 
            // dgvSEAccount
            // 
            this.dgvSEAccount.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSEAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSEAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AFACCTNO,
            this.ACCTNO,
            this.CODEID,
            this.SYMBOL,
            this.TOTALBUYAMT,
            this.LASTDATE});
            this.dgvSEAccount.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSEAccount.Location = new System.Drawing.Point(26, 40);
            this.dgvSEAccount.Name = "dgvSEAccount";
            this.dgvSEAccount.RowHeadersWidth = 51;
            this.dgvSEAccount.RowTemplate.Height = 24;
            this.dgvSEAccount.Size = new System.Drawing.Size(835, 297);
            this.dgvSEAccount.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbPP);
            this.panel1.Controls.Add(this.lbDEPOFEEAMT);
            this.panel1.Controls.Add(this.lbBALANCE);
            this.panel1.Controls.Add(this.btnEnter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 148);
            this.panel1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(465, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sức mua :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(465, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nợ phí hiện tại :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tiền mặt :";
            // 
            // lbPP
            // 
            this.lbPP.AutoSize = true;
            this.lbPP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPP.Location = new System.Drawing.Point(649, 113);
            this.lbPP.Name = "lbPP";
            this.lbPP.Size = new System.Drawing.Size(58, 22);
            this.lbPP.TabIndex = 4;
            this.lbPP.Text = "label3";
            // 
            // lbDEPOFEEAMT
            // 
            this.lbDEPOFEEAMT.AutoSize = true;
            this.lbDEPOFEEAMT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDEPOFEEAMT.Location = new System.Drawing.Point(649, 69);
            this.lbDEPOFEEAMT.Name = "lbDEPOFEEAMT";
            this.lbDEPOFEEAMT.Size = new System.Drawing.Size(58, 22);
            this.lbDEPOFEEAMT.TabIndex = 3;
            this.lbDEPOFEEAMT.Text = "label2";
            // 
            // lbBALANCE
            // 
            this.lbBALANCE.AutoSize = true;
            this.lbBALANCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBALANCE.Location = new System.Drawing.Point(649, 23);
            this.lbBALANCE.Name = "lbBALANCE";
            this.lbBALANCE.Size = new System.Drawing.Size(58, 22);
            this.lbBALANCE.TabIndex = 2;
            this.lbBALANCE.Text = "label1";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(48, 61);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(107, 30);
            this.btnEnter.TabIndex = 1;
            this.btnEnter.Text = "Nhập";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // AFACCTNO
            // 
            this.AFACCTNO.DataPropertyName = "AFACCTNO";
            this.AFACCTNO.HeaderText = "Tài khoản giao dịch";
            this.AFACCTNO.MinimumWidth = 6;
            this.AFACCTNO.Name = "AFACCTNO";
            this.AFACCTNO.Width = 125;
            // 
            // ACCTNO
            // 
            this.ACCTNO.DataPropertyName = "ACCTNO";
            this.ACCTNO.HeaderText = "Tài khoản CK";
            this.ACCTNO.MinimumWidth = 6;
            this.ACCTNO.Name = "ACCTNO";
            this.ACCTNO.Width = 125;
            // 
            // CODEID
            // 
            this.CODEID.DataPropertyName = "CODEID";
            this.CODEID.HeaderText = "Mã CK";
            this.CODEID.MinimumWidth = 6;
            this.CODEID.Name = "CODEID";
            this.CODEID.Width = 125;
            // 
            // SYMBOL
            // 
            this.SYMBOL.DataPropertyName = "SYMBOL";
            this.SYMBOL.HeaderText = "Mã niêm yết";
            this.SYMBOL.MinimumWidth = 6;
            this.SYMBOL.Name = "SYMBOL";
            this.SYMBOL.Width = 125;
            // 
            // TOTALBUYAMT
            // 
            this.TOTALBUYAMT.DataPropertyName = "TOTALBUYAMT";
            this.TOTALBUYAMT.HeaderText = "Số lượng CK";
            this.TOTALBUYAMT.MinimumWidth = 6;
            this.TOTALBUYAMT.Name = "TOTALBUYAMT";
            this.TOTALBUYAMT.Width = 125;
            // 
            // LASTDATE
            // 
            this.LASTDATE.DataPropertyName = "LASTDATE";
            this.LASTDATE.HeaderText = "Ngày GD cuối cùng";
            this.LASTDATE.MinimumWidth = 6;
            this.LASTDATE.Name = "LASTDATE";
            this.LASTDATE.Width = 125;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 538);
            this.Controls.Add(this.grbKhachHang);
            this.Controls.Add(this.panel1);
            this.Name = "frmAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAccount";
            this.Load += new System.EventHandler(this.frmAccount_Load);
            this.grbKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSEAccount)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKhachHang;
        private System.Windows.Forms.DataGridView dgvSEAccount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lbPP;
        private System.Windows.Forms.Label lbDEPOFEEAMT;
        private System.Windows.Forms.Label lbBALANCE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AFACCTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODEID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYMBOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALBUYAMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASTDATE;
    }
}