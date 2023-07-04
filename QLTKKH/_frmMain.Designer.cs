namespace QLTKKH
{
    partial class _frmMain
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiểuKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiềnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứngKhoánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đặtLệnhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhMụcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kháchHàngToolStripMenuItem,
            this.tiểuKhoảnToolStripMenuItem,
            this.tiềnToolStripMenuItem,
            this.chứngKhoánToolStripMenuItem,
            this.đặtLệnhToolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(90, 26);
            this.danhMụcToolStripMenuItem.Text = "Danh Mục";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.kháchHàngToolStripMenuItem.Text = "Khách Hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // tiểuKhoảnToolStripMenuItem
            // 
            this.tiểuKhoảnToolStripMenuItem.Name = "tiểuKhoảnToolStripMenuItem";
            this.tiểuKhoảnToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.tiểuKhoảnToolStripMenuItem.Text = "Tiểu khoản";
            this.tiểuKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tiểuKhoảnToolStripMenuItem_Click);
            // 
            // tiềnToolStripMenuItem
            // 
            this.tiềnToolStripMenuItem.Name = "tiềnToolStripMenuItem";
            this.tiềnToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.tiềnToolStripMenuItem.Text = "Tiền";
            this.tiềnToolStripMenuItem.Click += new System.EventHandler(this.tiềnToolStripMenuItem_Click);
            // 
            // chứngKhoánToolStripMenuItem
            // 
            this.chứngKhoánToolStripMenuItem.Name = "chứngKhoánToolStripMenuItem";
            this.chứngKhoánToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.chứngKhoánToolStripMenuItem.Text = "Chứng khoán";
            this.chứngKhoánToolStripMenuItem.Click += new System.EventHandler(this.chứngKhoánToolStripMenuItem_Click);
            // 
            // đặtLệnhToolStripMenuItem
            // 
            this.đặtLệnhToolStripMenuItem.Name = "đặtLệnhToolStripMenuItem";
            this.đặtLệnhToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.đặtLệnhToolStripMenuItem.Text = "Xem lệnh";
            this.đặtLệnhToolStripMenuItem.Click += new System.EventHandler(this.đặtLệnhToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // _frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 497);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "_frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiểuKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiềnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứngKhoánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đặtLệnhToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

