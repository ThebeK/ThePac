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
            pnlMenu.Width=pbxMenu.Width;
            pbxMenu.Location = new Point(0, 0);
            hidden = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                pnlMenu.Width = pnlMenu.Width + 20;
                pbxMenu.Location =  new Point(180,0);
                if (pnlMenu.Width>=pw)
                {
                    tmrSlide.Stop();
                    hidden = false;
                    this.Refresh();
                }
            }
            else
            {
                pnlMenu.Width = pnlMenu.Width - 20;
                pbxMenu.Location = new Point(0, 0);
                if (pnlMenu.Width <= pbxMenu.Width)
                {
                    tmrSlide.Stop();
                    hidden = true;
                    this.Refresh();
                }
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
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
            
        }

        private void pbxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
