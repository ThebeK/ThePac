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
    public partial class UCViewOrders : UserControl
    {
        public UCViewOrders()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UCViewOrders v = new UCViewOrders();
            UCViewOrderItems vi = new UCViewOrderItems();
            v.Controls.Add(vi);
            vi.BringToFront();
            vi.Dock = DockStyle.Fill;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            UCViewOrders v = new UCViewOrders();
            UCViewOrderItems vi = new UCViewOrderItems();
            v.Controls.Add(vi);
            vi.BringToFront();
            vi.Dock = DockStyle.Fill;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            UCViewOrders v = new UCViewOrders();
            UCViewOrderItems vi = new UCViewOrderItems();
            v.splitContainer1.Controls.Add(vi);
            vi.BringToFront();
            vi.Dock = DockStyle.Fill;
        }
    }
}
