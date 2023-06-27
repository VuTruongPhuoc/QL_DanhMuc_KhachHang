namespace QLTKKH
{
    partial class frmAFMAST
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
            this.dgvAFMAST = new System.Windows.Forms.DataGridView();
            this.CUSTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRCRLIMITMAX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnDatLenh = new System.Windows.Forms.Button();
            this.grbKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAFMAST)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbKhachHang
            // 
            this.grbKhachHang.Controls.Add(this.dgvAFMAST);
            this.grbKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbKhachHang.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.grbKhachHang.Location = new System.Drawing.Point(0, 86);
            this.grbKhachHang.Name = "grbKhachHang";
            this.grbKhachHang.Size = new System.Drawing.Size(961, 395);
            this.grbKhachHang.TabIndex = 10;
            this.grbKhachHang.TabStop = false;
            this.grbKhachHang.Text = "Danh sách tiều khoản";
            // 
            // dgvAFMAST
            // 
            this.dgvAFMAST.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAFMAST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAFMAST.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CUSTID,
            this.ACCTNO,
            this.MARTYPE,
            this.MRCRLIMITMAX});
            this.dgvAFMAST.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvAFMAST.Location = new System.Drawing.Point(18, 30);
            this.dgvAFMAST.Name = "dgvAFMAST";
            this.dgvAFMAST.RowHeadersWidth = 51;
            this.dgvAFMAST.RowTemplate.Height = 24;
            this.dgvAFMAST.Size = new System.Drawing.Size(936, 365);
            this.dgvAFMAST.TabIndex = 0;
            this.dgvAFMAST.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAFMAST_CellDoubleClick);
            // 
            // CUSTID
            // 
            this.CUSTID.DataPropertyName = "CUSTID";
            this.CUSTID.HeaderText = "Mã khách hàng";
            this.CUSTID.MinimumWidth = 6;
            this.CUSTID.Name = "CUSTID";
            this.CUSTID.Width = 125;
            // 
            // ACCTNO
            // 
            this.ACCTNO.DataPropertyName = "ACCTNO";
            this.ACCTNO.HeaderText = "Số tiểu khoản";
            this.ACCTNO.MinimumWidth = 6;
            this.ACCTNO.Name = "ACCTNO";
            this.ACCTNO.Width = 125;
            // 
            // MARTYPE
            // 
            this.MARTYPE.DataPropertyName = "MARTYPE";
            this.MARTYPE.HeaderText = "Có cho vay?(Y/N):";
            this.MARTYPE.MinimumWidth = 6;
            this.MARTYPE.Name = "MARTYPE";
            this.MARTYPE.Width = 125;
            // 
            // MRCRLIMITMAX
            // 
            this.MRCRLIMITMAX.DataPropertyName = "MRCRLIMITMAX";
            this.MRCRLIMITMAX.HeaderText = "Hạn mức được vay";
            this.MRCRLIMITMAX.MinimumWidth = 6;
            this.MRCRLIMITMAX.Name = "MRCRLIMITMAX";
            this.MRCRLIMITMAX.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnDatLenh);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(961, 86);
            this.panel1.TabIndex = 9;
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
            this.btnSua.Location = new System.Drawing.Point(216, 27);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(107, 30);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa ";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnDatLenh
            // 
            this.btnDatLenh.Location = new System.Drawing.Point(756, 27);
            this.btnDatLenh.Name = "btnDatLenh";
            this.btnDatLenh.Size = new System.Drawing.Size(132, 30);
            this.btnDatLenh.TabIndex = 4;
            this.btnDatLenh.Text = "Đặt lệnh";
            this.btnDatLenh.UseVisualStyleBackColor = true;
            this.btnDatLenh.Click += new System.EventHandler(this.btnDatLenh_Click);
            // 
            // frmAFMAST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 497);
            this.Controls.Add(this.grbKhachHang);
            this.Controls.Add(this.panel1);
            this.Name = "frmAFMAST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAFMAST";
            this.Load += new System.EventHandler(this.frmAFMAST_Load);
            this.grbKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAFMAST)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKhachHang;
        private System.Windows.Forms.DataGridView dgvAFMAST;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRCRLIMITMAX;
        private System.Windows.Forms.Button btnDatLenh;
    }
}