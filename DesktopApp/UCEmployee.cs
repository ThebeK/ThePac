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
    public partial class UCEmployee : UserControl
    {
        public UCEmployee()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            UCAddEmployee addOrder = new UCAddEmployee();
            panel4.Controls.Add(addOrder);
            addOrder.BringToFront();
            addOrder.Dock = DockStyle.Fill;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            UCAddEmployee addOrder = new UCAddEmployee();
            panel4.Controls.Add(addOrder);
            addOrder.BringToFront();
            addOrder.Dock = DockStyle.Fill;
        }
    }
}
