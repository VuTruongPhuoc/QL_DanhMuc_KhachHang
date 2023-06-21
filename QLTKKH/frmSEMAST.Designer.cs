namespace QLTKKH
{
    partial class frmSEMAST
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
            this.dgvSEMAST = new System.Windows.Forms.DataGridView();
            this.AFACCTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALBUYAMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPNDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLSDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LASTDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSECURITIES_INFO = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.grbKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSEMAST)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbKhachHang
            // 
            this.grbKhachHang.Controls.Add(this.dgvSEMAST);
            this.grbKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbKhachHang.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.grbKhachHang.Location = new System.Drawing.Point(0, 86);
            this.grbKhachHang.Name = "grbKhachHang";
            this.grbKhachHang.Size = new System.Drawing.Size(1166, 395);
            this.grbKhachHang.TabIndex = 10;
            this.grbKhachHang.TabStop = false;
            this.grbKhachHang.Text = "Tài sản CK KH";
            // 
            // dgvSEMAST
            // 
            this.dgvSEMAST.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSEMAST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSEMAST.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AFACCTNO,
            this.ACCTNO,
            this.CODEID,
            this.TOTALBUYAMT,
            this.OPNDATE,
            this.CLSDATE,
            this.LASTDATE});
            this.dgvSEMAST.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSEMAST.Location = new System.Drawing.Point(18, 30);
            this.dgvSEMAST.Name = "dgvSEMAST";
            this.dgvSEMAST.RowHeadersWidth = 51;
            this.dgvSEMAST.RowTemplate.Height = 24;
            this.dgvSEMAST.Size = new System.Drawing.Size(1132, 349);
            this.dgvSEMAST.TabIndex = 0;
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
            this.ACCTNO.HeaderText = "Số tài khoán CK";
            this.ACCTNO.MinimumWidth = 6;
            this.ACCTNO.Name = "ACCTNO";
            this.ACCTNO.Width = 125;
            // 
            // CODEID
            // 
            this.CODEID.DataPropertyName = "CODEID";
            this.CODEID.HeaderText = "ID chứng khoán ";
            this.CODEID.MinimumWidth = 6;
            this.CODEID.Name = "CODEID";
            this.CODEID.Width = 125;
            // 
            // TOTALBUYAMT
            // 
            this.TOTALBUYAMT.DataPropertyName = "TOTALBUYAMT";
            this.TOTALBUYAMT.HeaderText = "Tổng số lượng CK";
            this.TOTALBUYAMT.MinimumWidth = 6;
            this.TOTALBUYAMT.Name = "TOTALBUYAMT";
            this.TOTALBUYAMT.Width = 125;
            // 
            // OPNDATE
            // 
            this.OPNDATE.DataPropertyName = "OPNDATE";
            this.OPNDATE.HeaderText = "Ngày mở TK";
            this.OPNDATE.MinimumWidth = 6;
            this.OPNDATE.Name = "OPNDATE";
            this.OPNDATE.Width = 125;
            // 
            // CLSDATE
            // 
            this.CLSDATE.DataPropertyName = "CLSDATE";
            this.CLSDATE.HeaderText = "Ngày đóng TK";
            this.CLSDATE.MinimumWidth = 6;
            this.CLSDATE.Name = "CLSDATE";
            this.CLSDATE.Width = 125;
            // 
            // LASTDATE
            // 
            this.LASTDATE.DataPropertyName = "LASTDATE";
            this.LASTDATE.HeaderText = "Ngày GD cuối cùng";
            this.LASTDATE.MinimumWidth = 6;
            this.LASTDATE.Name = "LASTDATE";
            this.LASTDATE.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnSECURITIES_INFO);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 86);
            this.panel1.TabIndex = 9;
            // 
            // btnSECURITIES_INFO
            // 
            this.btnSECURITIES_INFO.Location = new System.Drawing.Point(817, 27);
            this.btnSECURITIES_INFO.Name = "btnSECURITIES_INFO";
            this.btnSECURITIES_INFO.Size = new System.Drawing.Size(229, 30);
            this.btnSECURITIES_INFO.TabIndex = 4;
            this.btnSECURITIES_INFO.Text = "Xem thông tin chứng khoán";
            this.btnSECURITIES_INFO.UseVisualStyleBackColor = true;
            this.btnSECURITIES_INFO.Click += new System.EventHandler(this.btnSECURITIES_INFO_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(47, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 30);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(382, 27);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 30);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(211, 27);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 30);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // frmSEMAST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 488);
            this.Controls.Add(this.grbKhachHang);
            this.Controls.Add(this.panel1);
            this.Name = "frmSEMAST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSEMAST";
            this.Load += new System.EventHandler(this.frmSEMAST_Load);
            this.grbKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSEMAST)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKhachHang;
        private System.Windows.Forms.DataGridView dgvSEMAST;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn AFACCTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODEID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALBUYAMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPNDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLSDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASTDATE;
        private System.Windows.Forms.Button btnSECURITIES_INFO;
    }
}