namespace QLTKKH
{
    partial class frmCFMAST
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
            this.dgvCFMAST = new System.Windows.Forms.DataGridView();
            this.CUSTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FULLNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTODYCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MOBILE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDuyet = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.grbKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCFMAST)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbKhachHang
            // 
            this.grbKhachHang.Controls.Add(this.dgvCFMAST);
            this.grbKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbKhachHang.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.grbKhachHang.Location = new System.Drawing.Point(0, 86);
            this.grbKhachHang.Name = "grbKhachHang";
            this.grbKhachHang.Size = new System.Drawing.Size(1172, 395);
            this.grbKhachHang.TabIndex = 8;
            this.grbKhachHang.TabStop = false;
            this.grbKhachHang.Text = "Danh sách khách hàng";
            // 
            // dgvCFMAST
            // 
            this.dgvCFMAST.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCFMAST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCFMAST.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUSTID,
            this.FULLNAME,
            this.CUSTODYCD,
            this.IDTYPE,
            this.IDCODE,
            this.IDDATE,
            this.ADDRESS,
            this.Phone,
            this.MOBILE,
            this.EMAIL});
            this.dgvCFMAST.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCFMAST.Location = new System.Drawing.Point(28, 40);
            this.dgvCFMAST.Name = "dgvCFMAST";
            this.dgvCFMAST.RowHeadersWidth = 51;
            this.dgvCFMAST.RowTemplate.Height = 24;
            this.dgvCFMAST.Size = new System.Drawing.Size(1132, 349);
            this.dgvCFMAST.TabIndex = 0;
            // 
            // CUSTID
            // 
            this.CUSTID.DataPropertyName = "CUSTID";
            this.CUSTID.HeaderText = "Mã khách hàng";
            this.CUSTID.MinimumWidth = 6;
            this.CUSTID.Name = "CUSTID";
            this.CUSTID.Width = 125;
            // 
            // FULLNAME
            // 
            this.FULLNAME.DataPropertyName = "FULLNAME";
            this.FULLNAME.HeaderText = "Họ và tên";
            this.FULLNAME.MinimumWidth = 6;
            this.FULLNAME.Name = "FULLNAME";
            this.FULLNAME.Width = 125;
            // 
            // CUSTODYCD
            // 
            this.CUSTODYCD.DataPropertyName = "CUSTODYCD";
            this.CUSTODYCD.HeaderText = "Số lưu ký";
            this.CUSTODYCD.MinimumWidth = 6;
            this.CUSTODYCD.Name = "CUSTODYCD";
            this.CUSTODYCD.Width = 125;
            // 
            // IDTYPE
            // 
            this.IDTYPE.DataPropertyName = "IDTYPE";
            this.IDTYPE.HeaderText = "Loại giấy tờ";
            this.IDTYPE.MinimumWidth = 6;
            this.IDTYPE.Name = "IDTYPE";
            this.IDTYPE.Width = 125;
            // 
            // IDCODE
            // 
            this.IDCODE.DataPropertyName = "IDCODE";
            this.IDCODE.HeaderText = "Số chứng thư";
            this.IDCODE.MinimumWidth = 6;
            this.IDCODE.Name = "IDCODE";
            this.IDCODE.Width = 125;
            // 
            // IDDATE
            // 
            this.IDDATE.DataPropertyName = "IDDATE";
            this.IDDATE.HeaderText = "Ngày cấp";
            this.IDDATE.MinimumWidth = 6;
            this.IDDATE.Name = "IDDATE";
            this.IDDATE.Width = 125;
            // 
            // ADDRESS
            // 
            this.ADDRESS.DataPropertyName = "ADDRESS";
            this.ADDRESS.HeaderText = "Địa Chỉ";
            this.ADDRESS.MinimumWidth = 6;
            this.ADDRESS.Name = "ADDRESS";
            this.ADDRESS.Width = 125;
            // 
            // Phone
            // 
            this.Phone.DataPropertyName = "Phone";
            this.Phone.HeaderText = "Điện thoại";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.Width = 125;
            // 
            // MOBILE
            // 
            this.MOBILE.DataPropertyName = "MOBILE";
            this.MOBILE.HeaderText = "Số mobile phone";
            this.MOBILE.MinimumWidth = 6;
            this.MOBILE.Name = "MOBILE";
            this.MOBILE.Width = 125;
            // 
            // EMAIL
            // 
            this.EMAIL.DataPropertyName = "EMAIL";
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.MinimumWidth = 6;
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnDuyet);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1172, 86);
            this.panel1.TabIndex = 7;
            // 
            // btnDuyet
            // 
            this.btnDuyet.Location = new System.Drawing.Point(533, 28);
            this.btnDuyet.Name = "btnDuyet";
            this.btnDuyet.Size = new System.Drawing.Size(107, 30);
            this.btnDuyet.TabIndex = 5;
            this.btnDuyet.Text = "Duyệt";
            this.btnDuyet.UseVisualStyleBackColor = true;
            this.btnDuyet.Click += new System.EventHandler(this.btnDuyet_Click);
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
            // frmCFMAST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 524);
            this.Controls.Add(this.grbKhachHang);
            this.Controls.Add(this.panel1);
            this.Name = "frmCFMAST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            this.grbKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCFMAST)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKhachHang;
        private System.Windows.Forms.DataGridView dgvCFMAST;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FULLNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTODYCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOBILE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnDuyet;
    }
}