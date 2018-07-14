using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QRCoder;
using System.Drawing.Imaging;
using System.IO;

namespace DesktopApp
{
    public partial class UCPackageOrder : UserControl
    {
        public UCPackageOrder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UCPackageOrder_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
          
        }
        

        

        


        private void selectIconBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxQRCode_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            frmGenerateQR f = new frmGenerateQR();
            f.ShowDialog();
        }
    }
}