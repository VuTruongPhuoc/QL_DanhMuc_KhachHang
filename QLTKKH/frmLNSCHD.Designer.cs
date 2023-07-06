namespace QLTKKH
{
    partial class frmLNSCHD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbNO = new System.Windows.Forms.GroupBox();
            this.dgvLNSCHD = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AUTOID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACCTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NML = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FEE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INTNMLACR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OVD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PAID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OVERDUEDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLSDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbNO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLNSCHD)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbNO
            // 
            this.grbNO.Controls.Add(this.dgvLNSCHD);
            this.grbNO.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbNO.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.grbNO.Location = new System.Drawing.Point(0, 86);
            this.grbNO.Name = "grbNO";
            this.grbNO.Size = new System.Drawing.Size(1010, 395);
            this.grbNO.TabIndex = 12;
            this.grbNO.TabStop = false;
            this.grbNO.Text = "Danh sách tài khoản nợ";
            // 
            // dgvLNSCHD
            // 
            this.dgvLNSCHD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLNSCHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLNSCHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AUTOID,
            this.ACCTNO,
            this.NML,
            this.FEE,
            this.INTNMLACR,
            this.OVD,
            this.PAID,
            this.OVERDUEDATE,
            this.RLSDATE});
            this.dgvLNSCHD.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLNSCHD.Location = new System.Drawing.Point(28, 40);
            this.dgvLNSCHD.Name = "dgvLNSCHD";
            this.dgvLNSCHD.RowHeadersWidth = 51;
            this.dgvLNSCHD.RowTemplate.Height = 24;
            this.dgvLNSCHD.Size = new System.Drawing.Size(970, 349);
            this.dgvLNSCHD.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 86);
            this.panel1.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin tài khoản nợ.";
            // 
            // AUTOID
            // 
            this.AUTOID.DataPropertyName = "AUTOID";
            this.AUTOID.HeaderText = "STT";
            this.AUTOID.MinimumWidth = 6;
            this.AUTOID.Name = "AUTOID";
            this.AUTOID.Width = 125;
            // 
            // ACCTNO
            // 
            this.ACCTNO.DataPropertyName = "ACCTNO";
            this.ACCTNO.HeaderText = "Số tài khoản";
            this.ACCTNO.MinimumWidth = 6;
            this.ACCTNO.Name = "ACCTNO";
            this.ACCTNO.Width = 125;
            // 
            // NML
            // 
            this.NML.DataPropertyName = "NML";
            this.NML.HeaderText = "Gốc trong hạn";
            this.NML.MinimumWidth = 6;
            this.NML.Name = "NML";
            this.NML.Width = 125;
            // 
            // FEE
            // 
            this.FEE.DataPropertyName = "FEE";
            dataGridViewCellStyle2.Format = "N2";
            this.FEE.DefaultCellStyle = dataGridViewCellStyle2;
            this.FEE.HeaderText = "Phí";
            this.FEE.MinimumWidth = 6;
            this.FEE.Name = "FEE";
            this.FEE.Width = 125;
            // 
            // INTNMLACR
            // 
            this.INTNMLACR.DataPropertyName = "INTNMLACR";
            this.INTNMLACR.HeaderText = "Lãi cộng dồn";
            this.INTNMLACR.MinimumWidth = 6;
            this.INTNMLACR.Name = "INTNMLACR";
            this.INTNMLACR.Width = 125;
            // 
            // OVD
            // 
            this.OVD.DataPropertyName = "OVD";
            this.OVD.HeaderText = "Gốc quá hạn";
            this.OVD.MinimumWidth = 6;
            this.OVD.Name = "OVD";
            this.OVD.Width = 125;
            // 
            // PAID
            // 
            this.PAID.DataPropertyName = "PAID";
            this.PAID.HeaderText = "Gốc đã trả";
            this.PAID.MinimumWidth = 6;
            this.PAID.Name = "PAID";
            this.PAID.Width = 125;
            // 
            // OVERDUEDATE
            // 
            this.OVERDUEDATE.DataPropertyName = "OVERDUEDATE";
            this.OVERDUEDATE.HeaderText = "Ngày đến hạn";
            this.OVERDUEDATE.MinimumWidth = 6;
            this.OVERDUEDATE.Name = "OVERDUEDATE";
            this.OVERDUEDATE.Width = 125;
            // 
            // RLSDATE
            // 
            this.RLSDATE.DataPropertyName = "RLSDATE";
            this.RLSDATE.HeaderText = "Ngày giải ngân";
            this.RLSDATE.MinimumWidth = 6;
            this.RLSDATE.Name = "RLSDATE";
            this.RLSDATE.Width = 125;
            // 
            // frmLNSCHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 525);
            this.Controls.Add(this.grbNO);
            this.Controls.Add(this.panel1);
            this.Name = "frmLNSCHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLNSCHD";
            this.Load += new System.EventHandler(this.frmLNSCHD_Load);
            this.grbNO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLNSCHD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNO;
        private System.Windows.Forms.DataGridView dgvLNSCHD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTOID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NML;
        private System.Windows.Forms.DataGridViewTextBoxColumn FEE;
        private System.Windows.Forms.DataGridViewTextBoxColumn INTNMLACR;
        private System.Windows.Forms.DataGridViewTextBoxColumn OVD;
        private System.Windows.Forms.DataGridViewTextBoxColumn PAID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OVERDUEDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLSDATE;
    }
}