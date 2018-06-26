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
    public partial class frmCreditReturn : Form
    {
        public frmCreditReturn()
        {
            InitializeComponent();
        }

        private void pbxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbxMaxNorm_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Normal)
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

        private void pbxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
