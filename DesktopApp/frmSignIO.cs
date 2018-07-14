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
    public partial class frmSignIO : Form
    {
        public frmSignIO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmScanQR f = new frmScanQR();
            f.ShowDialog();
            textBox3.Text= f.DecodeID;
        }
    }
}
