namespace QLTKKH
{
    partial class frmSECURITIES_INFO
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
            this.dgvSECURITIES_INFO = new System.Windows.Forms.DataGridView();
            this.CODEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYMBOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLOORPRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CELINGPRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BASICPRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MRRATIORATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMPANY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.grbKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSECURITIES_INFO)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbKhachHang
            // 
            this.grbKhachHang.Controls.Add(this.dgvSECURITIES_INFO);
            this.grbKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbKhachHang.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.grbKhachHang.Location = new System.Drawing.Point(0, 86);
            this.grbKhachHang.Name = "grbKhachHang";
            this.grbKhachHang.Size = new System.Drawing.Size(1025, 395);
            this.grbKhachHang.TabIndex = 12;
            this.grbKhachHang.TabStop = false;
            this.grbKhachHang.Text = "Tài sản CK KH";
            // 
            // dgvSECURITIES_INFO
            // 
            this.dgvSECURITIES_INFO.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSECURITIES_INFO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSECURITIES_INFO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODEID,
            this.SYMBOL,
            this.FLOORPRICE,
            this.CELINGPRICE,
            this.BASICPRICE,
            this.MRRATIORATE,
            this.COMPANY});
            this.dgvSECURITIES_INFO.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSECURITIES_INFO.Location = new System.Drawing.Point(18, 30);
            this.dgvSECURITIES_INFO.Name = "dgvSECURITIES_INFO";
            this.dgvSECURITIES_INFO.RowHeadersWidth = 51;
            this.dgvSECURITIES_INFO.RowTemplate.Height = 24;
            this.dgvSECURITIES_INFO.Size = new System.Drawing.Size(979, 343);
            this.dgvSECURITIES_INFO.TabIndex = 0;
            // 
            // CODEID
            // 
            this.CODEID.DataPropertyName = "CODEID";
            this.CODEID.HeaderText = "ID chứng khoán ";
            this.CODEID.MinimumWidth = 6;
            this.CODEID.Name = "CODEID";
            this.CODEID.Width = 125;
            // 
            // SYMBOL
            // 
            this.SYMBOL.DataPropertyName = "SYMBOL";
            this.SYMBOL.HeaderText = "Mã niêm yết GD";
            this.SYMBOL.MinimumWidth = 6;
            this.SYMBOL.Name = "SYMBOL";
            this.SYMBOL.Width = 125;
            // 
            // FLOORPRICE
            // 
            this.FLOORPRICE.DataPropertyName = "FLOORPRICE";
            this.FLOORPRICE.HeaderText = "Giá sàn";
            this.FLOORPRICE.MinimumWidth = 6;
            this.FLOORPRICE.Name = "FLOORPRICE";
            this.FLOORPRICE.Width = 125;
            // 
            // CELINGPRICE
            // 
            this.CELINGPRICE.DataPropertyName = "CELINGPRICE";
            this.CELINGPRICE.HeaderText = "Giá trần";
            this.CELINGPRICE.MinimumWidth = 6;
            this.CELINGPRICE.Name = "CELINGPRICE";
            this.CELINGPRICE.Width = 125;
            // 
            // BASICPRICE
            // 
            this.BASICPRICE.DataPropertyName = "BASICPRICE";
            this.BASICPRICE.HeaderText = "Giá tham chiếu";
            this.BASICPRICE.MinimumWidth = 6;
            this.BASICPRICE.Name = "BASICPRICE";
            this.BASICPRICE.Width = 125;
            // 
            // MRRATIORATE
            // 
            this.MRRATIORATE.DataPropertyName = "MRRATIORATE";
            this.MRRATIORATE.HeaderText = "Tỉ lệ tính tài sản CK";
            this.MRRATIORATE.MinimumWidth = 6;
            this.MRRATIORATE.Name = "MRRATIORATE";
            this.MRRATIORATE.Width = 125;
            // 
            // COMPANY
            // 
            this.COMPANY.DataPropertyName = "COMPANY";
            this.COMPANY.HeaderText = "Công ty CK";
            this.COMPANY.MinimumWidth = 6;
            this.COMPANY.Name = "COMPANY";
            this.COMPANY.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 86);
            this.panel1.TabIndex = 11;
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
            // 
            // frmSECURITIES_INFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 522);
            this.Controls.Add(this.grbKhachHang);
            this.Controls.Add(this.panel1);
            this.Name = "frmSECURITIES_INFO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSECURITIES_INFO";
            this.Load += new System.EventHandler(this.frmSECURITIES_INFO_Load);
            this.grbKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSECURITIES_INFO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKhachHang;
        private System.Windows.Forms.DataGridView dgvSECURITIES_INFO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODEID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYMBOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn FLOORPRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CELINGPRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn BASICPRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MRRATIORATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMPANY;
    }
}