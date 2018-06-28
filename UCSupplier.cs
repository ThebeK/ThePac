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
            UCViewOrders ViewOrder = new UCViewOrders();
            panel4.Controls.Add(ViewOrder);
            ViewOrder.BringToFront();
            ViewOrder.Dock = DockStyle.Fill;
        }
    }
}
