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

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            UCRoutePlan Rp = new UCRoutePlan();
            panel4.Controls.Add(Rp);
            Rp.BringToFront();
            Rp.Dock = DockStyle.Fill;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            UCPackageOrder Package = new UCPackageOrder();
            panel4.Controls.Add(Package);
            Package.BringToFront();
            Package.Dock = DockStyle.Fill;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            UCLoadForDelivery LoadDelivery = new UCLoadForDelivery();
            panel4.Controls.Add(LoadDelivery);
            LoadDelivery.BringToFront();
            LoadDelivery.Dock = DockStyle.Fill;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblGeneratePO_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lblMaintainPO_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmScanQR f = new frmScanQR();
            f.ShowDialog();
        }
    }
}
