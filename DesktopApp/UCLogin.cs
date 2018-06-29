using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class UCLogin : UserControl
    {
        public UCLogin()
        {
            InitializeComponent();
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.ToLower() == "" && txtPassword.Text == "")
            {

                frmMain activeForm = new frmMain(true);
                activeForm.Text = "active";
                activeForm.WindowState = FormWindowState.Maximized;
                activeForm.ShowDialog();



            }
            else
            {
                MessageBox.Show("Incorrect details");
            }
        }
    }
}
