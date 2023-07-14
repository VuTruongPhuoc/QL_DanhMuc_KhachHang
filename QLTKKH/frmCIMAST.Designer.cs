namespace QLTKKH
{
    partial class frmCIMAST
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
            this.dgvCIMAST = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQuanLy = new System.Windows.Forms.Button();
            this.AFACCTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BALANCE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIDEPOFEEACR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPOFEEAMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CURRENTDEBT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LASTCHANGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCIMAST)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbKhachHang
            // 
            this.grbKhachHang.Controls.Add(this.dgvCIMAST);
            this.grbKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbKhachHang.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.grbKhachHang.Location = new System.Drawing.Point(0, 86);
            this.grbKhachHang.Name = "grbKhachHang";
            this.grbKhachHang.Size = new System.Drawing.Size(868, 404);
            this.grbKhachHang.TabIndex = 12;
            this.grbKhachHang.TabStop = false;
            this.grbKhachHang.Text = "Danh sách tiền KH";
            // 
            // dgvCIMAST
            // 
            this.dgvCIMAST.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCIMAST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCIMAST.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AFACCTNO,
            this.ACCTNO,
            this.BALANCE,
            this.PP,
            this.CIDEPOFEEACR,
            this.DEPOFEEAMT,
            this.CURRENTDEBT,
            this.STATUS,
            this.LASTCHANGE});
            this.dgvCIMAST.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvCIMAST.Location = new System.Drawing.Point(12, 28);
            this.dgvCIMAST.Name = "dgvCIMAST";
            this.dgvCIMAST.RowHeadersWidth = 51;
            this.dgvCIMAST.RowTemplate.Height = 24;
            this.dgvCIMAST.Size = new System.Drawing.Size(845, 348);
            this.dgvCIMAST.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnQuanLy);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 86);
            this.panel1.TabIndex = 11;
            // 
            // btnQuanLy
            // 
            this.btnQuanLy.Location = new System.Drawing.Point(54, 28);
            this.btnQuanLy.Name = "btnQuanLy";
            this.btnQuanLy.Size = new System.Drawing.Size(107, 30);
            this.btnQuanLy.TabIndex = 6;
            this.btnQuanLy.Text = "Quản Lý";
            this.btnQuanLy.UseVisualStyleBackColor = true;
            this.btnQuanLy.Click += new System.EventHandler(this.btnQuanLy_Click);
            // 
            // AFACCTNO
            // 
            this.AFACCTNO.DataPropertyName = "AFACCTNO";
            this.AFACCTNO.HeaderText = "Số tiểu khoản";
            this.AFACCTNO.MinimumWidth = 6;
            this.AFACCTNO.Name = "AFACCTNO";
            this.AFACCTNO.Width = 125;
            // 
            // ACCTNO
            // 
            this.ACCTNO.DataPropertyName = "ACCTNO";
            this.ACCTNO.HeaderText = "Tài khoản tiền";
            this.ACCTNO.MinimumWidth = 6;
            this.ACCTNO.Name = "ACCTNO";
            this.ACCTNO.Width = 125;
            // 
            // BALANCE
            // 
            this.BALANCE.DataPropertyName = "BALANCE";
            this.BALANCE.HeaderText = "Số tiền hiện tại";
            this.BALANCE.MinimumWidth = 6;
            this.BALANCE.Name = "BALANCE";
            this.BALANCE.Width = 125;
            // 
            // PP
            // 
            this.PP.DataPropertyName = "PP";
            this.PP.HeaderText = "Sức mua";
            this.PP.MinimumWidth = 6;
            this.PP.Name = "PP";
            this.PP.Width = 125;
            // 
            // CIDEPOFEEACR
            // 
            this.CIDEPOFEEACR.DataPropertyName = "CIDEPOFEEACR";
            this.CIDEPOFEEACR.HeaderText = "Tổng phí hàng ngày";
            this.CIDEPOFEEACR.MinimumWidth = 6;
            this.CIDEPOFEEACR.Name = "CIDEPOFEEACR";
            this.CIDEPOFEEACR.Width = 125;
            // 
            // DEPOFEEAMT
            // 
            this.DEPOFEEAMT.DataPropertyName = "DEPOFEEAMT";
            this.DEPOFEEAMT.HeaderText = "Phí thu tháng";
            this.DEPOFEEAMT.MinimumWidth = 6;
            this.DEPOFEEAMT.Name = "DEPOFEEAMT";
            this.DEPOFEEAMT.Width = 125;
            // 
            // CURRENTDEBT
            // 
            this.CURRENTDEBT.DataPropertyName = "CURRENTDEBT";
            this.CURRENTDEBT.HeaderText = "Nợ hiện tại";
            this.CURRENTDEBT.MinimumWidth = 6;
            this.CURRENTDEBT.Name = "CURRENTDEBT";
            this.CURRENTDEBT.Width = 125;
            // 
            // STATUS
            // 
            this.STATUS.DataPropertyName = "STATUS";
            this.STATUS.HeaderText = "Trạng thái";
            this.STATUS.MinimumWidth = 6;
            this.STATUS.Name = "STATUS";
            this.STATUS.Width = 125;
            // 
            // LASTCHANGE
            // 
            this.LASTCHANGE.DataPropertyName = "LASTCHANGE";
            this.LASTCHANGE.HeaderText = "Ngày cập nhật cuối cùng";
            this.LASTCHANGE.MinimumWidth = 6;
            this.LASTCHANGE.Name = "LASTCHANGE";
            this.LASTCHANGE.Width = 125;
            // 
            // frmCIMAST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 539);
            this.Controls.Add(this.grbKhachHang);
            this.Controls.Add(this.panel1);
            this.Name = "frmCIMAST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCIMAST";
            this.Load += new System.EventHandler(this.frmCIMAST_Load);
            this.grbKhachHang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCIMAST)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbKhachHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQuanLy;
        private System.Windows.Forms.DataGridView dgvCIMAST;
        private System.Windows.Forms.DataGridViewTextBoxColumn AFACCTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BALANCE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PP;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIDEPOFEEACR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPOFEEAMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CURRENTDEBT;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASTCHANGE;
    }
}