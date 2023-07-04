namespace QLTKKH
{
    partial class frmSetCommand
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
            this.btnMua = new System.Windows.Forms.Button();
            this.btnBan = new System.Windows.Forms.Button();
            this.txtQUOTEPRICE = new System.Windows.Forms.TextBox();
            this.txtORDERQTTY = new System.Windows.Forms.TextBox();
            this.txtSYMBOL = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCUSTODYCD = new System.Windows.Forms.Label();
            this.btnDat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLenh = new System.Windows.Forms.Button();
            this.grbLenhDat = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAFACCTNO = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.grbLenhDat.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMua
            // 
            this.btnMua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMua.Location = new System.Drawing.Point(38, 23);
            this.btnMua.Name = "btnMua";
            this.btnMua.Size = new System.Drawing.Size(129, 39);
            this.btnMua.TabIndex = 0;
            this.btnMua.Text = "Mua";
            this.btnMua.UseVisualStyleBackColor = true;
            this.btnMua.Click += new System.EventHandler(this.btnMua_Click);
            // 
            // btnBan
            // 
            this.btnBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBan.Location = new System.Drawing.Point(200, 23);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(129, 39);
            this.btnBan.TabIndex = 1;
            this.btnBan.Text = "Bán";
            this.btnBan.UseVisualStyleBackColor = true;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // txtQUOTEPRICE
            // 
            this.txtQUOTEPRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQUOTEPRICE.Location = new System.Drawing.Point(278, 275);
            this.txtQUOTEPRICE.Multiline = true;
            this.txtQUOTEPRICE.Name = "txtQUOTEPRICE";
            this.txtQUOTEPRICE.Size = new System.Drawing.Size(238, 40);
            this.txtQUOTEPRICE.TabIndex = 55;
            // 
            // txtORDERQTTY
            // 
            this.txtORDERQTTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtORDERQTTY.Location = new System.Drawing.Point(278, 201);
            this.txtORDERQTTY.Multiline = true;
            this.txtORDERQTTY.Name = "txtORDERQTTY";
            this.txtORDERQTTY.Size = new System.Drawing.Size(238, 38);
            this.txtORDERQTTY.TabIndex = 54;
            // 
            // txtSYMBOL
            // 
            this.txtSYMBOL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSYMBOL.Location = new System.Drawing.Point(278, 123);
            this.txtSYMBOL.Multiline = true;
            this.txtSYMBOL.Name = "txtSYMBOL";
            this.txtSYMBOL.Size = new System.Drawing.Size(238, 39);
            this.txtSYMBOL.TabIndex = 53;
            this.txtSYMBOL.TextChanged += new System.EventHandler(this.txtSYMBOL_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(80, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 51;
            this.label4.Text = "Giá đặt lệnh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 50;
            this.label3.Text = "Số lượng:";
            // 
            // lbCUSTODYCD
            // 
            this.lbCUSTODYCD.AutoSize = true;
            this.lbCUSTODYCD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCUSTODYCD.Location = new System.Drawing.Point(80, 137);
            this.lbCUSTODYCD.Name = "lbCUSTODYCD";
            this.lbCUSTODYCD.Size = new System.Drawing.Size(164, 25);
            this.lbCUSTODYCD.TabIndex = 49;
            this.lbCUSTODYCD.Text = "Mã chứng khoán:";
            // 
            // btnDat
            // 
            this.btnDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDat.Location = new System.Drawing.Point(573, 477);
            this.btnDat.Name = "btnDat";
            this.btnDat.Size = new System.Drawing.Size(129, 39);
            this.btnDat.TabIndex = 56;
            this.btnDat.Text = "Đặt";
            this.btnDat.UseVisualStyleBackColor = true;
            this.btnDat.Click += new System.EventHandler(this.btnDat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btnLenh);
            this.panel1.Controls.Add(this.btnMua);
            this.panel1.Controls.Add(this.btnBan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 86);
            this.panel1.TabIndex = 57;
            // 
            // btnLenh
            // 
            this.btnLenh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLenh.Location = new System.Drawing.Point(510, 23);
            this.btnLenh.Name = "btnLenh";
            this.btnLenh.Size = new System.Drawing.Size(234, 39);
            this.btnLenh.TabIndex = 2;
            this.btnLenh.Text = "Xem lệnh";
            this.btnLenh.UseVisualStyleBackColor = true;
            this.btnLenh.Click += new System.EventHandler(this.btnLenh_Click);
            // 
            // grbLenhDat
            // 
            this.grbLenhDat.Controls.Add(this.txtAFACCTNO);
            this.grbLenhDat.Controls.Add(this.label1);
            this.grbLenhDat.Controls.Add(this.lbCUSTODYCD);
            this.grbLenhDat.Controls.Add(this.label3);
            this.grbLenhDat.Controls.Add(this.txtSYMBOL);
            this.grbLenhDat.Controls.Add(this.txtQUOTEPRICE);
            this.grbLenhDat.Controls.Add(this.txtORDERQTTY);
            this.grbLenhDat.Controls.Add(this.label4);
            this.grbLenhDat.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbLenhDat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbLenhDat.Location = new System.Drawing.Point(0, 86);
            this.grbLenhDat.Name = "grbLenhDat";
            this.grbLenhDat.Size = new System.Drawing.Size(780, 347);
            this.grbLenhDat.TabIndex = 58;
            this.grbLenhDat.TabStop = false;
            this.grbLenhDat.Text = "Trạng thái";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "Số tài khoản:";
            // 
            // txtAFACCTNO
            // 
            this.txtAFACCTNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAFACCTNO.Location = new System.Drawing.Point(278, 40);
            this.txtAFACCTNO.Multiline = true;
            this.txtAFACCTNO.Name = "txtAFACCTNO";
            this.txtAFACCTNO.ReadOnly = true;
            this.txtAFACCTNO.Size = new System.Drawing.Size(238, 39);
            this.txtAFACCTNO.TabIndex = 58;
            // 
            // frmSetCommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 548);
            this.Controls.Add(this.grbLenhDat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDat);
            this.Name = "frmSetCommand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đặt lệnh";
            this.Load += new System.EventHandler(this.frmSetCommand_Load);
            this.panel1.ResumeLayout(false);
            this.grbLenhDat.ResumeLayout(false);
            this.grbLenhDat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMua;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.TextBox txtQUOTEPRICE;
        private System.Windows.Forms.TextBox txtORDERQTTY;
        private System.Windows.Forms.TextBox txtSYMBOL;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCUSTODYCD;
        private System.Windows.Forms.Button btnDat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grbLenhDat;
        private System.Windows.Forms.Button btnLenh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAFACCTNO;
    }
}