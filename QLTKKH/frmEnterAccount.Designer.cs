namespace QLTKKH
{
    partial class frmEnterAccount
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCUSTODYCD = new System.Windows.Forms.Label();
            this.txtAFACCTNO = new System.Windows.Forms.TextBox();
            this.btnMaHopDong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboACCTNO = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboACCTNO);
            this.groupBox1.Controls.Add(this.txtAFACCTNO);
            this.groupBox1.Controls.Add(this.btnMaHopDong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbCUSTODYCD);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(78, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(503, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tài khoản";
            // 
            // lbCUSTODYCD
            // 
            this.lbCUSTODYCD.AutoSize = true;
            this.lbCUSTODYCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCUSTODYCD.Location = new System.Drawing.Point(35, 61);
            this.lbCUSTODYCD.Name = "lbCUSTODYCD";
            this.lbCUSTODYCD.Size = new System.Drawing.Size(117, 20);
            this.lbCUSTODYCD.TabIndex = 53;
            this.lbCUSTODYCD.Text = "Tài khoản GD:";
            // 
            // txtAFACCTNO
            // 
            this.txtAFACCTNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAFACCTNO.Location = new System.Drawing.Point(198, 49);
            this.txtAFACCTNO.Multiline = true;
            this.txtAFACCTNO.Name = "txtAFACCTNO";
            this.txtAFACCTNO.Size = new System.Drawing.Size(210, 32);
            this.txtAFACCTNO.TabIndex = 57;
            // 
            // btnMaHopDong
            // 
            this.btnMaHopDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaHopDong.Location = new System.Drawing.Point(447, 153);
            this.btnMaHopDong.Name = "btnMaHopDong";
            this.btnMaHopDong.Size = new System.Drawing.Size(41, 36);
            this.btnMaHopDong.TabIndex = 56;
            this.btnMaHopDong.Text = "....";
            this.btnMaHopDong.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = "Mã hợp đồng:";
            // 
            // cboACCTNO
            // 
            this.cboACCTNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboACCTNO.FormattingEnabled = true;
            this.cboACCTNO.Location = new System.Drawing.Point(198, 148);
            this.cboACCTNO.Name = "cboACCTNO";
            this.cboACCTNO.Size = new System.Drawing.Size(210, 33);
            this.cboACCTNO.TabIndex = 58;
            // 
            // frmEnterAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 662);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEnterAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nhập";
            this.Load += new System.EventHandler(this.frmEnterAccount_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbCUSTODYCD;
        private System.Windows.Forms.ComboBox cboACCTNO;
        private System.Windows.Forms.TextBox txtAFACCTNO;
        private System.Windows.Forms.Button btnMaHopDong;
        private System.Windows.Forms.Label label1;
    }
}