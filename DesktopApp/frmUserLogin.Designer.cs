namespace DesktopApp
{
    partial class frmMain
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tmrSlide = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessLeveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imlMaxNorm = new System.Windows.Forms.ImageList(this.components);
            this.pbxMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbxMin = new System.Windows.Forms.PictureBox();
            this.pbxMaxNorm = new System.Windows.Forms.PictureBox();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ucLogin1 = new DesktopApp.UCLogin();
            this.panel2.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaxNorm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.pbxMin);
            this.panel2.Controls.Add(this.pbxMaxNorm);
            this.panel2.Controls.Add(this.pbxClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 40);
            this.panel2.TabIndex = 2;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlMenu.Controls.Add(this.menuStrip2);
            this.pnlMenu.Controls.Add(this.pbxMenu);
            this.pnlMenu.Controls.Add(this.pictureBox1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 40);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 360);
            this.pnlMenu.TabIndex = 3;
            // 
            // tmrSlide
            // 
            this.tmrSlide.Interval = 30;
            this.tmrSlide.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(200, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 30);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ucLogin1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(200, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 300);
            this.panel3.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.accessLeveToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.vehicleToolStripMenuItem});
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Tekton Pro Ext", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(104, 26);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(211, 28);
            this.userToolStripMenuItem.Text = "User";
            // 
            // accessLeveToolStripMenuItem
            // 
            this.accessLeveToolStripMenuItem.Name = "accessLeveToolStripMenuItem";
            this.accessLeveToolStripMenuItem.Size = new System.Drawing.Size(211, 28);
            this.accessLeveToolStripMenuItem.Text = "Access Level";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(211, 28);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // vehicleToolStripMenuItem
            // 
            this.vehicleToolStripMenuItem.Name = "vehicleToolStripMenuItem";
            this.vehicleToolStripMenuItem.Size = new System.Drawing.Size(211, 28);
            this.vehicleToolStripMenuItem.Text = "Vehicle";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(211, 28);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Tekton Pro Ext", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(74, 26);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip2.Font = new System.Drawing.Font("Tekton Pro Ext", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.saleToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.productToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 80);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(199, 280);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.AutoSize = false;
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloToolStripMenuItem});
            this.dashboardToolStripMenuItem.Image = global::DesktopApp.Properties.Resources.WhatsApp_Image_2018_03_08_at_21_18_15;
            this.dashboardToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(192, 37);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.Image = global::DesktopApp.Properties.Resources.WhatsApp_Image_2018_03_08_at_21_18_15;
            this.ordersToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(192, 37);
            this.ordersToolStripMenuItem.Text = "Order";
            this.ordersToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.Image = global::DesktopApp.Properties.Resources.WhatsApp_Image_2018_03_08_at_21_18_15;
            this.saleToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(192, 37);
            this.saleToolStripMenuItem.Text = "Sale";
            this.saleToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Image = global::DesktopApp.Properties.Resources.WhatsApp_Image_2018_03_08_at_21_18_15;
            this.clientToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(192, 37);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Image = global::DesktopApp.Properties.Resources.WhatsApp_Image_2018_03_08_at_21_18_15;
            this.productToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(192, 37);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Image = global::DesktopApp.Properties.Resources.WhatsApp_Image_2018_03_08_at_21_18_15;
            this.supplierToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(192, 37);
            this.supplierToolStripMenuItem.Text = "Supplier";
            this.supplierToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Image = global::DesktopApp.Properties.Resources.WhatsApp_Image_2018_03_08_at_21_18_15;
            this.reportToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(192, 37);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(155, 38);
            this.helloToolStripMenuItem.Text = "hello";
            // 
            // imlMaxNorm
            // 
            this.imlMaxNorm.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imlMaxNorm.ImageSize = new System.Drawing.Size(16, 16);
            this.imlMaxNorm.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pbxMenu
            // 
            this.pbxMenu.BackColor = System.Drawing.Color.DarkGray;
            this.pbxMenu.Location = new System.Drawing.Point(170, 0);
            this.pbxMenu.Name = "pbxMenu";
            this.pbxMenu.Size = new System.Drawing.Size(30, 30);
            this.pbxMenu.TabIndex = 1;
            this.pbxMenu.TabStop = false;
            this.pbxMenu.Click += new System.EventHandler(this.pbxMenu_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::DesktopApp.Properties.Resources.WhatsApp_Image_2018_03_08_at_21_18_15;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pbxMin
            // 
            this.pbxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMin.BackColor = System.Drawing.Color.DarkGray;
            this.pbxMin.Location = new System.Drawing.Point(695, 3);
            this.pbxMin.Name = "pbxMin";
            this.pbxMin.Size = new System.Drawing.Size(30, 30);
            this.pbxMin.TabIndex = 11;
            this.pbxMin.TabStop = false;
            this.pbxMin.Click += new System.EventHandler(this.pbxMin_Click);
            // 
            // pbxMaxNorm
            // 
            this.pbxMaxNorm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMaxNorm.BackColor = System.Drawing.Color.DarkGray;
            this.pbxMaxNorm.Location = new System.Drawing.Point(731, 3);
            this.pbxMaxNorm.Name = "pbxMaxNorm";
            this.pbxMaxNorm.Size = new System.Drawing.Size(30, 30);
            this.pbxMaxNorm.TabIndex = 10;
            this.pbxMaxNorm.TabStop = false;
            this.pbxMaxNorm.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pbxClose
            // 
            this.pbxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxClose.BackColor = System.Drawing.Color.DarkGray;
            this.pbxClose.Location = new System.Drawing.Point(767, 3);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(30, 30);
            this.pbxClose.TabIndex = 9;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(200, 370);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(600, 30);
            this.panel4.TabIndex = 6;
            // 
            // ucLogin1
            // 
            this.ucLogin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLogin1.Location = new System.Drawing.Point(0, 0);
            this.ucLogin1.Name = "ucLogin1";
            this.ucLogin1.Size = new System.Drawing.Size(600, 300);
            this.ucLogin1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Main";
            this.panel2.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaxNorm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Timer tmrSlide;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbxMin;
        private System.Windows.Forms.PictureBox pbxMaxNorm;
        private System.Windows.Forms.PictureBox pbxClose;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessLeveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
        private System.Windows.Forms.ImageList imlMaxNorm;
        private UCLogin ucLogin1;
        private System.Windows.Forms.Panel panel4;
    }
}