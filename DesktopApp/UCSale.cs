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
    public partial class UCSale : UserControl
    {
        public UCSale()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UCMakeSale makeSale = new UCMakeSale();
            this.panel4.Controls.Add(makeSale);
            makeSale.BringToFront();
            makeSale.Dock = DockStyle.Fill;
            
            
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UCRefund RefundSale = new UCRefund();
            this.panel4.Controls.Add(RefundSale);
            RefundSale.BringToFront();
            RefundSale.Dock = DockStyle.Fill;
        }
    }
}
