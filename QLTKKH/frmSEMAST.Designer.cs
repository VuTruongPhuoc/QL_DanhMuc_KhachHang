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
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.CUSTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AFACCTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTALSELLAMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPNDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLSDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LASTDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbKhachHang
            // 
            this.grbKhachHang.Controls.Add(this.dgvCustomer);
            this.grbKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbKhachHang.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.grbKhachHang.Location = new System.Drawing.Point(0, 86);
            this.grbKhachHang.Name = "grbKhachHang";
            this.grbKhachHang.Size = new System.Drawing.Size(1166, 395);
            this.grbKhachHang.TabIndex = 10;
            this.grbKhachHang.TabStop = false;
            this.grbKhachHang.Text = "Tài sản CK KH";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUSTID,
            this.AFACCTNO,
            this.ACCTNO,
            this.CODEID,
            this.TOTALSELLAMT,
            this.OPNDATE,
            this.CLSDATE,
            this.LASTDATE});
            this.dgvCustomer.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCustomer.Location = new System.Drawing.Point(18, 30);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(1132, 349);
            this.dgvCustomer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1166, 86);
            this.panel1.TabIndex = 9;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(548, 27);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(107, 30);
            this.btnLamMoi.TabIndex = 6;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(47, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(107, 30);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(382, 27);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 30);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(211, 27);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 30);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // CUSTID
            // 
            this.CUSTID.DataPropertyName = "CUSTID";
            this.CUSTID.HeaderText = "Mã khách hàng";
            this.CUSTID.MinimumWidth = 6;
            this.CUSTID.Name = "CUSTID";
            this.CUSTID.Width = 125;
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
            // TOTALSELLAMT
            // 
            this.TOTALSELLAMT.DataPropertyName = "TOTALSELLAMT";
            this.TOTALSELLAMT.HeaderText = "Tổng giá trị CK";
            this.TOTALSELLAMT.MinimumWidth = 6;
            this.TOTALSELLAMT.Name = "TOTALSELLAMT";
            this.TOTALSELLAMT.Width = 125;
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
            // frmSEMAST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 488);
            this.Controls.Add(this.grbKhachHang);
            this.Controls.Add(this.panel1);
            this.Name = "frmSEMAST";
            this.Text = "frmSEMAST";
            this.grbKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKhachHang;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AFACCTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODEID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTALSELLAMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPNDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLSDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASTDATE;
    }
}