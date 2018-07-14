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
    public partial class frmAutherization : Form
    {
        public frmAutherization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmResetPasswrd f = new frmResetPasswrd();
            f.ShowDialog();
            f.BringToFront();
            f.Activate();
            f.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
          

        }
    }
}
