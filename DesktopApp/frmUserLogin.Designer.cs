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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbxMin = new System.Windows.Forms.PictureBox();
            this.pbxMaxNorm = new System.Windows.Forms.PictureBox();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pbxMenu = new System.Windows.Forms.PictureBox();
            this.tmrSlide = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerUserPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainUserProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessLeveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAccessLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainAccessLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateCompanyInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintainVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ucLogin1 = new DesktopApp.UCLogin();
            this.ucDashboard1 = new DesktopApp.UCDashboard();
            this.imlMaxNorm = new System.Windows.Forms.ImageList(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaxNorm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            // pbxMin
            // 
            this.pbxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMin.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbxMin.Image = ((System.Drawing.Image)(resources.GetObject("pbxMin.Image")));
            this.pbxMin.Location = new System.Drawing.Point(695, 3);
            this.pbxMin.Name = "pbxMin";
            this.pbxMin.Size = new System.Drawing.Size(30, 30);
            this.pbxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMin.TabIndex = 11;
            this.pbxMin.TabStop = false;
            this.pbxMin.Click += new System.EventHandler(this.pbxMin_Click);
            // 
            // pbxMaxNorm
            // 
            this.pbxMaxNorm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMaxNorm.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbxMaxNorm.Image = ((System.Drawing.Image)(resources.GetObject("pbxMaxNorm.Image")));
            this.pbxMaxNorm.Location = new System.Drawing.Point(731, 3);
            this.pbxMaxNorm.Name = "pbxMaxNorm";
            this.pbxMaxNorm.Size = new System.Drawing.Size(30, 30);
            this.pbxMaxNorm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMaxNorm.TabIndex = 10;
            this.pbxMaxNorm.TabStop = false;
            this.pbxMaxNorm.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pbxClose
            // 
            this.pbxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbxClose.Image = ((System.Drawing.Image)(resources.GetObject("pbxClose.Image")));
            this.pbxClose.Location = new System.Drawing.Point(767, 3);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(30, 30);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxClose.TabIndex = 9;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlMenu.Controls.Add(this.menuStrip2);
            this.pnlMenu.Controls.Add(this.panel5);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 40);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(202, 430);
            this.pnlMenu.TabIndex = 3;
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.saleToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.productToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.reportToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 40);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(200, 390);
            this.menuStrip2.TabIndex = 3;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.AutoSize = false;
            this.dashboardToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dashboardToolStripMenuItem.Image")));
            this.dashboardToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(190, 50);
            this.dashboardToolStripMenuItem.Text = "Home";
            this.dashboardToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.AutoSize = false;
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseOrderToolStripMenuItem,
            this.supplierOrderToolStripMenuItem});
            this.ordersToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ordersToolStripMenuItem.Image")));
            this.ordersToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ordersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(190, 50);
            this.ordersToolStripMenuItem.Text = "Order";
            this.ordersToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // purchaseOrderToolStripMenuItem
            // 
            this.purchaseOrderToolStripMenuItem.Name = "purchaseOrderToolStripMenuItem";
            this.purchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(293, 36);
            this.purchaseOrderToolStripMenuItem.Text = "Purchase Order";
            // 
            // supplierOrderToolStripMenuItem
            // 
            this.supplierOrderToolStripMenuItem.Name = "supplierOrderToolStripMenuItem";
            this.supplierOrderToolStripMenuItem.Size = new System.Drawing.Size(293, 36);
            this.supplierOrderToolStripMenuItem.Text = "Supplier Order";
            // 
            // saleToolStripMenuItem
            // 
            this.saleToolStripMenuItem.AutoSize = false;
            this.saleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saleToolStripMenuItem.Image")));
            this.saleToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saleToolStripMenuItem.Name = "saleToolStripMenuItem";
            this.saleToolStripMenuItem.Size = new System.Drawing.Size(190, 50);
            this.saleToolStripMenuItem.Text = "Sale";
            this.saleToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.AutoSize = false;
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addClientToolStripMenuItem,
            this.maintainProductToolStripMenuItem});
            this.clientToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("clientToolStripMenuItem.Image")));
            this.clientToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clientToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(190, 50);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addClientToolStripMenuItem
            // 
            this.addClientToolStripMenuItem.Name = "addClientToolStripMenuItem";
            this.addClientToolStripMenuItem.Size = new System.Drawing.Size(307, 36);
            this.addClientToolStripMenuItem.Text = "Add Client";
            // 
            // maintainProductToolStripMenuItem
            // 
            this.maintainProductToolStripMenuItem.Name = "maintainProductToolStripMenuItem";
            this.maintainProductToolStripMenuItem.Size = new System.Drawing.Size(307, 36);
            this.maintainProductToolStripMenuItem.Text = "Maintain Product";
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.AutoSize = false;
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewProductToolStripMenuItem,
            this.maintainToolStripMenuItem});
            this.productToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("productToolStripMenuItem.Image")));
            this.productToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(190, 50);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addNewProductToolStripMenuItem
            // 
            this.addNewProductToolStripMenuItem.Name = "addNewProductToolStripMenuItem";
            this.addNewProductToolStripMenuItem.Size = new System.Drawing.Size(307, 36);
            this.addNewProductToolStripMenuItem.Text = "Add Product";
            // 
            // maintainToolStripMenuItem
            // 
            this.maintainToolStripMenuItem.Name = "maintainToolStripMenuItem";
            this.maintainToolStripMenuItem.Size = new System.Drawing.Size(307, 36);
            this.maintainToolStripMenuItem.Text = "Maintain Product";
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.AutoSize = false;
            this.supplierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSupplierToolStripMenuItem,
            this.maintainSupplierToolStripMenuItem});
            this.supplierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("supplierToolStripMenuItem.Image")));
            this.supplierToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.supplierToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(190, 50);
            this.supplierToolStripMenuItem.Text = "Supplier";
            this.supplierToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addSupplierToolStripMenuItem
            // 
            this.addSupplierToolStripMenuItem.Name = "addSupplierToolStripMenuItem";
            this.addSupplierToolStripMenuItem.Size = new System.Drawing.Size(313, 36);
            this.addSupplierToolStripMenuItem.Text = "Add Supplier";
            // 
            // maintainSupplierToolStripMenuItem
            // 
            this.maintainSupplierToolStripMenuItem.Name = "maintainSupplierToolStripMenuItem";
            this.maintainSupplierToolStripMenuItem.Size = new System.Drawing.Size(313, 36);
            this.maintainSupplierToolStripMenuItem.Text = "Maintain Supplier";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.AutoSize = false;
            this.reportToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("reportToolStripMenuItem.Image")));
            this.reportToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(190, 50);
            this.reportToolStripMenuItem.Text = "Report";
            this.reportToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pbxMenu);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(202, 40);
            this.panel5.TabIndex = 4;
            // 
            // pbxMenu
            // 
            this.pbxMenu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pbxMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbxMenu.Image")));
            this.pbxMenu.Location = new System.Drawing.Point(161, 0);
            this.pbxMenu.Name = "pbxMenu";
            this.pbxMenu.Size = new System.Drawing.Size(40, 40);
            this.pbxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMenu.TabIndex = 1;
            this.pbxMenu.TabStop = false;
            this.pbxMenu.Click += new System.EventHandler(this.pbxMenu_Click);
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
            this.panel1.Location = new System.Drawing.Point(202, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(598, 30);
            this.panel1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(598, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(74, 26);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.accessLeveToolStripMenuItem,
            this.employeeToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.vehicleToolStripMenuItem});
            this.optionsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(94, 26);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerUserPasswordToolStripMenuItem,
            this.maintainUserProfileToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.userToolStripMenuItem.Text = "User";
            // 
            // registerUserPasswordToolStripMenuItem
            // 
            this.registerUserPasswordToolStripMenuItem.Name = "registerUserPasswordToolStripMenuItem";
            this.registerUserPasswordToolStripMenuItem.Size = new System.Drawing.Size(272, 28);
            this.registerUserPasswordToolStripMenuItem.Text = "Register User Profile";
            // 
            // maintainUserProfileToolStripMenuItem
            // 
            this.maintainUserProfileToolStripMenuItem.Name = "maintainUserProfileToolStripMenuItem";
            this.maintainUserProfileToolStripMenuItem.Size = new System.Drawing.Size(272, 28);
            this.maintainUserProfileToolStripMenuItem.Text = "Maintain User Profile";
            // 
            // accessLeveToolStripMenuItem
            // 
            this.accessLeveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAccessLevelToolStripMenuItem,
            this.maintainAccessLevelToolStripMenuItem});
            this.accessLeveToolStripMenuItem.Name = "accessLeveToolStripMenuItem";
            this.accessLeveToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.accessLeveToolStripMenuItem.Text = "Access Level";
            // 
            // addAccessLevelToolStripMenuItem
            // 
            this.addAccessLevelToolStripMenuItem.Name = "addAccessLevelToolStripMenuItem";
            this.addAccessLevelToolStripMenuItem.Size = new System.Drawing.Size(288, 28);
            this.addAccessLevelToolStripMenuItem.Text = "Add Access Level";
            // 
            // maintainAccessLevelToolStripMenuItem
            // 
            this.maintainAccessLevelToolStripMenuItem.Name = "maintainAccessLevelToolStripMenuItem";
            this.maintainAccessLevelToolStripMenuItem.Size = new System.Drawing.Size(288, 28);
            this.maintainAccessLevelToolStripMenuItem.Text = "Maintain Access Level";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.maintainEmployeeToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(258, 28);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            // 
            // maintainEmployeeToolStripMenuItem
            // 
            this.maintainEmployeeToolStripMenuItem.Name = "maintainEmployeeToolStripMenuItem";
            this.maintainEmployeeToolStripMenuItem.Size = new System.Drawing.Size(258, 28);
            this.maintainEmployeeToolStripMenuItem.Text = "Maintain Employee";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notificationToolStripMenuItem,
            this.updateCompanyInformationToolStripMenuItem,
            this.toolStripSeparator1,
            this.backupToolStripMenuItem,
            this.restoreToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // notificationToolStripMenuItem
            // 
            this.notificationToolStripMenuItem.Name = "notificationToolStripMenuItem";
            this.notificationToolStripMenuItem.Size = new System.Drawing.Size(349, 28);
            this.notificationToolStripMenuItem.Text = "Notification";
            // 
            // updateCompanyInformationToolStripMenuItem
            // 
            this.updateCompanyInformationToolStripMenuItem.Name = "updateCompanyInformationToolStripMenuItem";
            this.updateCompanyInformationToolStripMenuItem.Size = new System.Drawing.Size(349, 28);
            this.updateCompanyInformationToolStripMenuItem.Text = "Update Company Information";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(346, 6);
            // 
            // backupToolStripMenuItem
            // 
            this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
            this.backupToolStripMenuItem.Size = new System.Drawing.Size(349, 28);
            this.backupToolStripMenuItem.Text = "Backup";
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(349, 28);
            this.restoreToolStripMenuItem.Text = "Restore";
            // 
            // vehicleToolStripMenuItem
            // 
            this.vehicleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVehicleToolStripMenuItem,
            this.maintainVehicleToolStripMenuItem});
            this.vehicleToolStripMenuItem.Name = "vehicleToolStripMenuItem";
            this.vehicleToolStripMenuItem.Size = new System.Drawing.Size(204, 28);
            this.vehicleToolStripMenuItem.Text = "Vehicle";
            // 
            // addVehicleToolStripMenuItem
            // 
            this.addVehicleToolStripMenuItem.Name = "addVehicleToolStripMenuItem";
            this.addVehicleToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.addVehicleToolStripMenuItem.Text = "Add Vehicle";
            // 
            // maintainVehicleToolStripMenuItem
            // 
            this.maintainVehicleToolStripMenuItem.Name = "maintainVehicleToolStripMenuItem";
            this.maintainVehicleToolStripMenuItem.Size = new System.Drawing.Size(235, 28);
            this.maintainVehicleToolStripMenuItem.Text = "Maintain Vehicle";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.ucLogin1);
            this.panel3.Controls.Add(this.ucDashboard1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(202, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(598, 400);
            this.panel3.TabIndex = 5;
            // 
            // ucLogin1
            // 
            this.ucLogin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucLogin1.Location = new System.Drawing.Point(0, 0);
            this.ucLogin1.Name = "ucLogin1";
            this.ucLogin1.Size = new System.Drawing.Size(598, 400);
            this.ucLogin1.TabIndex = 0;
            // 
            // ucDashboard1
            // 
            this.ucDashboard1.Location = new System.Drawing.Point(213, 197);
            this.ucDashboard1.Name = "ucDashboard1";
            this.ucDashboard1.Size = new System.Drawing.Size(662, 375);
            this.ucDashboard1.TabIndex = 1;
            // 
            // imlMaxNorm
            // 
            this.imlMaxNorm.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlMaxNorm.ImageStream")));
            this.imlMaxNorm.TransparentColor = System.Drawing.Color.Transparent;
            this.imlMaxNorm.Images.SetKeyName(0, "Maximise.png");
            this.imlMaxNorm.Images.SetKeyName(1, "Normal.png");
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 470);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 30);
            this.panel4.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Main";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaxNorm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMenu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Timer tmrSlide;
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
        private System.Windows.Forms.ImageList imlMaxNorm;
        private UCLogin ucLogin1;
        private System.Windows.Forms.Panel panel4;
        private UCDashboard ucDashboard1;
        private System.Windows.Forms.ToolStripMenuItem purchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerUserPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainUserProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAccessLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainAccessLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateCompanyInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintainSupplierToolStripMenuItem;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button1;
    }
}