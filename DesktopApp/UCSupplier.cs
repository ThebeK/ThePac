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
    public partial class UCSupplier : UserControl
    {
        public UCSupplier()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UCSuppAddOrder addOrder = new UCSuppAddOrder();
            panel4.Controls.Add(addOrder);
            addOrder.BringToFront();
            addOrder.Dock = DockStyle.Fill;
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UCViewOrders ViewOrders = new UCViewOrders();
            panel4.Controls.Add(ViewOrders);
            ViewOrders.BringToFront();
            ViewOrders.Dock = DockStyle.Fill;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ucSuppBackOrder SuppBackOrder = new ucSuppBackOrder();
            panel4.Controls.Add(SuppBackOrder);
            SuppBackOrder.BringToFront();
            SuppBackOrder.Dock = DockStyle.Fill;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            UCReceiveSO RSO = new UCReceiveSO();
            panel4.Controls.Add(RSO);
            RSO.BringToFront();
            RSO.Dock = DockStyle.Fill;
        }
    }
}
