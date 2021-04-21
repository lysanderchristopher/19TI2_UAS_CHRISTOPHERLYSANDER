namespace Inventory
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportpembelianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportpenjualanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.userToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1476, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buyToolStripMenuItem,
            this.sellStripMenuItem,
            this.reportpembelianToolStripMenuItem,
            this.reportpenjualanToolStripMenuItem});
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(68, 29);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // buyToolStripMenuItem
            // 
            this.buyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buyToolStripMenuItem.Image")));
            this.buyToolStripMenuItem.Name = "buyToolStripMenuItem";
            this.buyToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.buyToolStripMenuItem.Text = "Pembelian";
            this.buyToolStripMenuItem.Click += new System.EventHandler(this.buyToolStripMenuItem_Click);
            // 
            // sellStripMenuItem
            // 
            this.sellStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sellStripMenuItem.Image")));
            this.sellStripMenuItem.Name = "sellStripMenuItem";
            this.sellStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sellStripMenuItem.Text = "Penjualan";
            this.sellStripMenuItem.Click += new System.EventHandler(this.sellToolStripMenuItem_Click);
            // 
            // reportpembelianToolStripMenuItem
            // 
            this.reportpembelianToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportpembelianToolStripMenuItem.Image")));
            this.reportpembelianToolStripMenuItem.Name = "reportpembelianToolStripMenuItem";
            this.reportpembelianToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.reportpembelianToolStripMenuItem.Text = "Laporan Pembelian";
            this.reportpembelianToolStripMenuItem.Click += new System.EventHandler(this.reportpembelianToolStripMenuItem_Click);
            // 
            // reportpenjualanToolStripMenuItem
            // 
            this.reportpenjualanToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportpenjualanToolStripMenuItem.Image")));
            this.reportpenjualanToolStripMenuItem.Name = "reportpenjualanToolStripMenuItem";
            this.reportpenjualanToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.reportpenjualanToolStripMenuItem.Text = "Laporan Penjualan";
            this.reportpenjualanToolStripMenuItem.Click += new System.EventHandler(this.reportpenjualanToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockListToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(71, 29);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // stockListToolStripMenuItem
            // 
            this.stockListToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stockListToolStripMenuItem.Image")));
            this.stockListToolStripMenuItem.Name = "stockListToolStripMenuItem";
            this.stockListToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.stockListToolStripMenuItem.Text = "Daftar Stok";
            this.stockListToolStripMenuItem.Click += new System.EventHandler(this.stockListToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureAccountToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(63, 29);
            this.userToolStripMenuItem.Text = "User";
            // 
            // configureAccountToolStripMenuItem
            // 
            this.configureAccountToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("configureAccountToolStripMenuItem.Image")));
            this.configureAccountToolStripMenuItem.Name = "configureAccountToolStripMenuItem";
            this.configureAccountToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.configureAccountToolStripMenuItem.Text = "Daftar Akun";
            this.configureAccountToolStripMenuItem.Click += new System.EventHandler(this.configureAccountToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 1049);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMenu_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportpembelianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportpenjualanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}