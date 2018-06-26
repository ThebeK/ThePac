using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class frmMain : Form
    {
        int pw=200;
        bool hidden;
        public frmMain()
        {
            InitializeComponent();

            menuStrip2.Size = new Size(60, 390);
            ordersToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ordersToolStripMenuItem.Size = new Size(50, 50);
            dashboardToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            dashboardToolStripMenuItem.Size = new Size(50, 50);
            saleToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            saleToolStripMenuItem.Size = new Size(50, 50);
            clientToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            clientToolStripMenuItem.Size = new Size(50, 50);
            productToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            productToolStripMenuItem.Size = new Size(50, 50);
            supplierToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            supplierToolStripMenuItem.Size = new Size(50, 50);
            reportToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            reportToolStripMenuItem.Size = new Size(50, 50);

            pnlMenu.Width=60;
            pbxMenu.Location = new Point(12, 0);
            hidden = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                pnlMenu.Width = pnlMenu.Width + 20;
                pbxMenu.Location =  new Point(160,0);
                if (pnlMenu.Width>=pw)
                {
                    tmrSlide.Stop();
                    hidden = false;
                    this.Refresh();
                }
                menuStrip2.Size = new Size(200, 390);
                ordersToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                ordersToolStripMenuItem.Size = new Size(200, 50);
                dashboardToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                dashboardToolStripMenuItem.Size = new Size(200, 50);
                saleToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                saleToolStripMenuItem.Size = new Size(200, 50);
                clientToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                clientToolStripMenuItem.Size = new Size(200, 50);
                productToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                productToolStripMenuItem.Size = new Size(200, 50);
                supplierToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                supplierToolStripMenuItem.Size = new Size(200, 50);
                reportToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
                reportToolStripMenuItem.Size = new Size(200, 50);
            }
            else
            {
                pnlMenu.Width = pnlMenu.Width - 20;
                pbxMenu.Location = new Point(12, 0);
                if (pnlMenu.Width <= 60)
                {
                    tmrSlide.Stop();
                    hidden = true;
                    this.Refresh();
                }
                menuStrip2.Size = new Size(60, 390);
                ordersToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
                ordersToolStripMenuItem.Size = new Size(50, 50);
                dashboardToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
                dashboardToolStripMenuItem.Size = new Size(50, 50);
                saleToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
                saleToolStripMenuItem.Size = new Size(50, 50);
                clientToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
                clientToolStripMenuItem.Size = new Size(50, 50);
                productToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
                productToolStripMenuItem.Size = new Size(50, 50);
                supplierToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
                supplierToolStripMenuItem.Size = new Size(50, 50);
                reportToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
                reportToolStripMenuItem.Size = new Size(50, 50);
            }
        }

        private void pbxMenu_Click(object sender, EventArgs e)
        {
            if (hidden)
            {
                pbxMenu.Location = new Point(0, 0);
            }
            tmrSlide.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState==FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                pbxMaxNorm.Image = imlMaxNorm.Images[1];
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                pbxMaxNorm.Image = imlMaxNorm.Images[0];
            }
            
        }

        private void pbxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucDashboard1.BringToFront();
            ucDashboard1.Dock=DockStyle.Fill;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ucLogin1.BringToFront();
            ucLogin1.Dock = DockStyle.Fill;
        }

        public void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
          //  ucPurchaseOrder1.panel4.Controls.Clear();
            UCNull nullclient = new UCNull();
            ucPurchaseOrder1.panel4.Controls.Add(nullclient);
            nullclient.BringToFront();
            nullclient.Dock = DockStyle.Fill;
            ucPurchaseOrder1.BringToFront();
            ucPurchaseOrder1.Dock = DockStyle.Fill;

        }
    }
}
