﻿namespace QLTKKH
{
    partial class frmODMAST
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDatLenh = new System.Windows.Forms.Label();
            this.btnHuyLenh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvODMAST = new System.Windows.Forms.DataGridView();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDERID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAST_CHANGE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXECTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SYMBOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDERQTTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUOTEPRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXECQTTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EXECAMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REMAINQTTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CANCELQTTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BRATIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDSTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AFACCTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ORDERMATCH = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvODMAST)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lbDatLenh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1295, 72);
            this.panel1.TabIndex = 34;
            // 
            // lbDatLenh
            // 
            this.lbDatLenh.AutoSize = true;
            this.lbDatLenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDatLenh.Location = new System.Drawing.Point(3, 24);
            this.lbDatLenh.Name = "lbDatLenh";
            this.lbDatLenh.Size = new System.Drawing.Size(165, 20);
            this.lbDatLenh.TabIndex = 0;
            this.lbDatLenh.Text = "Thông tin đặt lệnh.";
            // 
            // btnHuyLenh
            // 
            this.btnHuyLenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyLenh.Location = new System.Drawing.Point(881, 555);
            this.btnHuyLenh.Name = "btnHuyLenh";
            this.btnHuyLenh.Size = new System.Drawing.Size(145, 43);
            this.btnHuyLenh.TabIndex = 1;
            this.btnHuyLenh.Text = "Huỷ lệnh";
            this.btnHuyLenh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHuyLenh.UseVisualStyleBackColor = true;
            this.btnHuyLenh.Click += new System.EventHandler(this.btnHuyLenh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvODMAST);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1295, 456);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đặt lệnh";
            // 
            // dgvODMAST
            // 
            this.dgvODMAST.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvODMAST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvODMAST.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.CUSTID,
            this.ORDERID,
            this.LAST_CHANGE,
            this.EXECTYPE,
            this.SYMBOL,
            this.ORDERQTTY,
            this.QUOTEPRICE,
            this.EXECQTTY,
            this.EXECAMT,
            this.REMAINQTTY,
            this.CANCELQTTY,
            this.BRATIO,
            this.EDSTATUS,
            this.AFACCTNO,
            this.CODEID,
            this.ORDERMATCH});
            this.dgvODMAST.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvODMAST.Location = new System.Drawing.Point(12, 39);
            this.dgvODMAST.Name = "dgvODMAST";
            this.dgvODMAST.RowHeadersVisible = false;
            this.dgvODMAST.RowHeadersWidth = 51;
            this.dgvODMAST.RowTemplate.Height = 24;
            this.dgvODMAST.Size = new System.Drawing.Size(1271, 411);
            this.dgvODMAST.TabIndex = 2;
            this.dgvODMAST.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvODMAST_CellContentClick);
            this.dgvODMAST.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvODMAST_CellFormatting);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(1084, 555);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(137, 43);
            this.btnThanhToan.TabIndex = 36;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // CUSTID
            // 
            this.CUSTID.DataPropertyName = "CUSTID";
            this.CUSTID.HeaderText = "Mã KH";
            this.CUSTID.MinimumWidth = 6;
            this.CUSTID.Name = "CUSTID";
            this.CUSTID.Width = 125;
            // 
            // ORDERID
            // 
            this.ORDERID.DataPropertyName = "ORDERID";
            this.ORDERID.HeaderText = "Mã đặt lệnh";
            this.ORDERID.MinimumWidth = 6;
            this.ORDERID.Name = "ORDERID";
            this.ORDERID.Width = 125;
            // 
            // LAST_CHANGE
            // 
            this.LAST_CHANGE.DataPropertyName = "LAST_CHANGE";
            dataGridViewCellStyle1.NullValue = null;
            this.LAST_CHANGE.DefaultCellStyle = dataGridViewCellStyle1;
            this.LAST_CHANGE.HeaderText = "Thời gian";
            this.LAST_CHANGE.MinimumWidth = 6;
            this.LAST_CHANGE.Name = "LAST_CHANGE";
            this.LAST_CHANGE.Width = 125;
            // 
            // EXECTYPE
            // 
            this.EXECTYPE.DataPropertyName = "EXECTYPE";
            this.EXECTYPE.HeaderText = "Loại lệnh";
            this.EXECTYPE.MinimumWidth = 6;
            this.EXECTYPE.Name = "EXECTYPE";
            this.EXECTYPE.Width = 125;
            // 
            // SYMBOL
            // 
            this.SYMBOL.DataPropertyName = "SYMBOL";
            this.SYMBOL.HeaderText = "Mã CK";
            this.SYMBOL.MinimumWidth = 6;
            this.SYMBOL.Name = "SYMBOL";
            this.SYMBOL.Width = 125;
            // 
            // ORDERQTTY
            // 
            this.ORDERQTTY.DataPropertyName = "ORDERQTTY";
            this.ORDERQTTY.HeaderText = "Số lượng đặt";
            this.ORDERQTTY.MinimumWidth = 6;
            this.ORDERQTTY.Name = "ORDERQTTY";
            this.ORDERQTTY.Width = 125;
            // 
            // QUOTEPRICE
            // 
            this.QUOTEPRICE.DataPropertyName = "QUOTEPRICE";
            this.QUOTEPRICE.HeaderText = "Giá";
            this.QUOTEPRICE.MinimumWidth = 6;
            this.QUOTEPRICE.Name = "QUOTEPRICE";
            this.QUOTEPRICE.Width = 125;
            // 
            // EXECQTTY
            // 
            this.EXECQTTY.DataPropertyName = "EXECQTTY";
            this.EXECQTTY.HeaderText = "Số lượng khớp";
            this.EXECQTTY.MinimumWidth = 6;
            this.EXECQTTY.Name = "EXECQTTY";
            this.EXECQTTY.Width = 125;
            // 
            // EXECAMT
            // 
            this.EXECAMT.DataPropertyName = "EXECAMT";
            this.EXECAMT.HeaderText = "Giá trị khớp";
            this.EXECAMT.MinimumWidth = 6;
            this.EXECAMT.Name = "EXECAMT";
            this.EXECAMT.Width = 125;
            // 
            // REMAINQTTY
            // 
            this.REMAINQTTY.DataPropertyName = "REMAINQTTY";
            this.REMAINQTTY.HeaderText = "Số lượng còn lại";
            this.REMAINQTTY.MinimumWidth = 6;
            this.REMAINQTTY.Name = "REMAINQTTY";
            this.REMAINQTTY.Width = 125;
            // 
            // CANCELQTTY
            // 
            this.CANCELQTTY.DataPropertyName = "CANCELQTTY";
            this.CANCELQTTY.HeaderText = "Số lượng huỷ";
            this.CANCELQTTY.MinimumWidth = 6;
            this.CANCELQTTY.Name = "CANCELQTTY";
            this.CANCELQTTY.Width = 125;
            // 
            // BRATIO
            // 
            this.BRATIO.DataPropertyName = "BRATIO";
            this.BRATIO.HeaderText = "Phí";
            this.BRATIO.MinimumWidth = 6;
            this.BRATIO.Name = "BRATIO";
            this.BRATIO.Width = 125;
            // 
            // EDSTATUS
            // 
            this.EDSTATUS.DataPropertyName = "EDSTATUS";
            this.EDSTATUS.HeaderText = "Trạng thái";
            this.EDSTATUS.MinimumWidth = 6;
            this.EDSTATUS.Name = "EDSTATUS";
            this.EDSTATUS.Width = 125;
            // 
            // AFACCTNO
            // 
            this.AFACCTNO.DataPropertyName = "AFACCTNO";
            this.AFACCTNO.HeaderText = "Số tài khoản";
            this.AFACCTNO.MinimumWidth = 6;
            this.AFACCTNO.Name = "AFACCTNO";
            this.AFACCTNO.Width = 125;
            // 
            // CODEID
            // 
            this.CODEID.DataPropertyName = "CODEID";
            this.CODEID.HeaderText = "ID Chứng khoán";
            this.CODEID.MinimumWidth = 6;
            this.CODEID.Name = "CODEID";
            this.CODEID.Width = 125;
            // 
            // ORDERMATCH
            // 
            this.ORDERMATCH.DataPropertyName = "ORDERMATCH";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Beige;
            this.ORDERMATCH.DefaultCellStyle = dataGridViewCellStyle2;
            this.ORDERMATCH.HeaderText = "Thực hiện";
            this.ORDERMATCH.MinimumWidth = 6;
            this.ORDERMATCH.Name = "ORDERMATCH";
            this.ORDERMATCH.Text = "Khớp lệnh";
            this.ORDERMATCH.UseColumnTextForButtonValue = true;
            this.ORDERMATCH.Width = 125;
            // 
            // frmODMAST
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 610);
            this.Controls.Add(this.btnHuyLenh);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "frmODMAST";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmODMAST";
            this.Load += new System.EventHandler(this.frmODMAST_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvODMAST)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDatLenh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvODMAST;
        private System.Windows.Forms.Button btnHuyLenh;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUSTID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDERID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LAST_CHANGE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXECTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SYMBOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ORDERQTTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUOTEPRICE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXECQTTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn EXECAMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn REMAINQTTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn CANCELQTTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn BRATIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDSTATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn AFACCTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODEID;
        private System.Windows.Forms.DataGridViewButtonColumn ORDERMATCH;
    }
}