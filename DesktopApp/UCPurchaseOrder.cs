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
    public partial class UCPurchaseOrder : UserControl
    {
        public UCPurchaseOrder()
        {
            InitializeComponent();
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {
            UCAddOrder ucAddOrder1 = new UCAddOrder();
            panel4.Controls.Add(ucAddOrder1);
            ucAddOrder1.BringToFront();
            ucAddOrder1.Dock = DockStyle.Fill;


        }

        public void pictureBox2_Click(object sender, EventArgs e)
        {

            ucBackOrder ucBackOrder1 = new ucBackOrder();
            panel4.Controls.Add(ucBackOrder1);
            ucBackOrder1.BringToFront();
            ucBackOrder1.Dock = DockStyle.Fill;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            UCConfirmDelivery ucConfirmDelivery1 = new UCConfirmDelivery();
            panel4.Controls.Add(ucConfirmDelivery1);
            ucConfirmDelivery1.BringToFront();
            ucConfirmDelivery1.Dock = DockStyle.Fill;
        }
    }
}
