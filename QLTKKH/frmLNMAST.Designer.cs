namespace QLTKKH
{
    partial class frmLNMAST
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
            this.grbNO = new System.Windows.Forms.GroupBox();
            this.dgvLNMAST = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ACCTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRINNML = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INTDUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INTNMLACR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRINPAID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INTPAID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRINOVD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INTNMLOVD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INTOVDACR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RATE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RATE2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RATE3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LASTDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPNDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RLSDATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbNO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLNMAST)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbNO
            // 
            this.grbNO.Controls.Add(this.dgvLNMAST);
            this.grbNO.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbNO.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.grbNO.Location = new System.Drawing.Point(0, 86);
            this.grbNO.Name = "grbNO";
            this.grbNO.Size = new System.Drawing.Size(1177, 395);
            this.grbNO.TabIndex = 10;
            this.grbNO.TabStop = false;
            this.grbNO.Text = "Danh sách tài khoản nợ";
            // 
            // dgvLNMAST
            // 
            this.dgvLNMAST.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLNMAST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLNMAST.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ACCTNO,
            this.PRINNML,
            this.INTDUE,
            this.INTNMLACR,
            this.PRINPAID,
            this.INTPAID,
            this.PRINOVD,
            this.INTNMLOVD,
            this.INTOVDACR,
            this.RATE1,
            this.RATE2,
            this.RATE3,
            this.LASTDATE,
            this.OPNDATE,
            this.RLSDATE});
            this.dgvLNMAST.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLNMAST.Location = new System.Drawing.Point(28, 40);
            this.dgvLNMAST.Name = "dgvLNMAST";
            this.dgvLNMAST.RowHeadersWidth = 51;
            this.dgvLNMAST.RowTemplate.Height = 24;
            this.dgvLNMAST.Size = new System.Drawing.Size(1132, 349);
            this.dgvLNMAST.TabIndex = 0;
            this.dgvLNMAST.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLNMAST_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 86);
            this.panel1.TabIndex = 9;
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
            // ACCTNO
            // 
            this.ACCTNO.DataPropertyName = "ACCTNO";
            this.ACCTNO.HeaderText = "Số tài khoản";
            this.ACCTNO.MinimumWidth = 6;
            this.ACCTNO.Name = "ACCTNO";
            this.ACCTNO.Width = 125;
            // 
            // PRINNML
            // 
            this.PRINNML.DataPropertyName = "PRINNML";
            this.PRINNML.HeaderText = "Gốc trong hạn";
            this.PRINNML.MinimumWidth = 6;
            this.PRINNML.Name = "PRINNML";
            this.PRINNML.Width = 125;
            // 
            // INTDUE
            // 
            this.INTDUE.DataPropertyName = "INTDUE";
            this.INTDUE.HeaderText = "Lãi trong hạn";
            this.INTDUE.MinimumWidth = 6;
            this.INTDUE.Name = "INTDUE";
            this.INTDUE.Width = 125;
            // 
            // INTNMLACR
            // 
            this.INTNMLACR.DataPropertyName = "INTNMLACR";
            this.INTNMLACR.HeaderText = "Lãi cộng dồn";
            this.INTNMLACR.MinimumWidth = 6;
            this.INTNMLACR.Name = "INTNMLACR";
            this.INTNMLACR.Width = 125;
            // 
            // PRINPAID
            // 
            this.PRINPAID.DataPropertyName = "PRINPAID";
            this.PRINPAID.HeaderText = "Gốc đã trả";
            this.PRINPAID.MinimumWidth = 6;
            this.PRINPAID.Name = "PRINPAID";
            this.PRINPAID.Width = 125;
            // 
            // INTPAID
            // 
            this.INTPAID.DataPropertyName = "INTPAID";
            this.INTPAID.HeaderText = "Lãi đã trả";
            this.INTPAID.MinimumWidth = 6;
            this.INTPAID.Name = "INTPAID";
            this.INTPAID.Width = 125;
            // 
            // PRINOVD
            // 
            this.PRINOVD.DataPropertyName = "PRINOVD";
            this.PRINOVD.HeaderText = "Gốc quá hạn";
            this.PRINOVD.MinimumWidth = 6;
            this.PRINOVD.Name = "PRINOVD";
            this.PRINOVD.Width = 125;
            // 
            // INTNMLOVD
            // 
            this.INTNMLOVD.DataPropertyName = "INTNMLOVD";
            this.INTNMLOVD.HeaderText = "Lãi quá hạn";
            this.INTNMLOVD.MinimumWidth = 6;
            this.INTNMLOVD.Name = "INTNMLOVD";
            this.INTNMLOVD.Width = 125;
            // 
            // INTOVDACR
            // 
            this.INTOVDACR.DataPropertyName = "INTOVDACR";
            this.INTOVDACR.HeaderText = "Lãi quá hạn cộng dồn";
            this.INTOVDACR.MinimumWidth = 6;
            this.INTOVDACR.Name = "INTOVDACR";
            this.INTOVDACR.Width = 125;
            // 
            // RATE1
            // 
            this.RATE1.DataPropertyName = "RATE1";
            this.RATE1.HeaderText = "Mức lãi hạn 1";
            this.RATE1.MinimumWidth = 6;
            this.RATE1.Name = "RATE1";
            this.RATE1.Width = 125;
            // 
            // RATE2
            // 
            this.RATE2.DataPropertyName = "RATE2";
            this.RATE2.HeaderText = "Mức lãi hạn 2";
            this.RATE2.MinimumWidth = 6;
            this.RATE2.Name = "RATE2";
            this.RATE2.Width = 125;
            // 
            // RATE3
            // 
            this.RATE3.DataPropertyName = "RATE3";
            this.RATE3.HeaderText = "Mức lãi hạn 3";
            this.RATE3.MinimumWidth = 6;
            this.RATE3.Name = "RATE3";
            this.RATE3.Width = 125;
            // 
            // LASTDATE
            // 
            this.LASTDATE.DataPropertyName = "LASTDATE";
            this.LASTDATE.HeaderText = "Ngày GD cuối cùng";
            this.LASTDATE.MinimumWidth = 6;
            this.LASTDATE.Name = "LASTDATE";
            this.LASTDATE.Width = 125;
            // 
            // OPNDATE
            // 
            this.OPNDATE.DataPropertyName = "OPNDATE";
            this.OPNDATE.HeaderText = "Ngày mở tài khoản";
            this.OPNDATE.MinimumWidth = 6;
            this.OPNDATE.Name = "OPNDATE";
            this.OPNDATE.Width = 125;
            // 
            // RLSDATE
            // 
            this.RLSDATE.DataPropertyName = "RLSDATE";
            this.RLSDATE.HeaderText = "Ngày giải ngân";
            this.RLSDATE.MinimumWidth = 6;
            this.RLSDATE.Name = "RLSDATE";
            this.RLSDATE.Width = 125;
            // 
            // frmLNMAST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 512);
            this.Controls.Add(this.grbNO);
            this.Controls.Add(this.panel1);
            this.Name = "frmLNMAST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLNMAST";
            this.Load += new System.EventHandler(this.frmLNMAST_Load);
            this.grbNO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLNMAST)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbNO;
        private System.Windows.Forms.DataGridView dgvLNMAST;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACCTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRINNML;
        private System.Windows.Forms.DataGridViewTextBoxColumn INTDUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn INTNMLACR;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRINPAID;
        private System.Windows.Forms.DataGridViewTextBoxColumn INTPAID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PRINOVD;
        private System.Windows.Forms.DataGridViewTextBoxColumn INTNMLOVD;
        private System.Windows.Forms.DataGridViewTextBoxColumn INTOVDACR;
        private System.Windows.Forms.DataGridViewTextBoxColumn RATE1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RATE2;
        private System.Windows.Forms.DataGridViewTextBoxColumn RATE3;
        private System.Windows.Forms.DataGridViewTextBoxColumn LASTDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPNDATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RLSDATE;
    }
}