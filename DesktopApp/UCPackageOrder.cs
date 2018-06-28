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
            comboBoxECC.SelectedIndex = 0; //Pre-select ECC level "L"
            RenderQrCode();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            RenderQrCode();
        }
        private void RenderQrCode()
        {
            string level = comboBoxECC.SelectedItem.ToString();
            QRCodeGenerator.ECCLevel eccLevel = (QRCodeGenerator.ECCLevel)(level == "L" ? 0 : level == "M" ? 1 : level == "Q" ? 2 : 3);
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(textBoxQRCode.Text, eccLevel))
                {
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {

                        pictureBoxQRCode.BackgroundImage = qrCode.GetGraphic(20, Color.Black, Color.White,
                            GetIconBitmap(), (int)iconSize.Value);

                        this.pictureBoxQRCode.Size = new System.Drawing.Size(pictureBoxQRCode.Width, pictureBoxQRCode.Height);
                        //Set the SizeMode to center the image.
                        this.pictureBoxQRCode.SizeMode = PictureBoxSizeMode.CenterImage;

                        pictureBoxQRCode.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
        }

        private Bitmap GetIconBitmap()
        {
            Bitmap img = null;
            if (iconPath.Text.Length > 0)
            {
                try
                {
                    img = new Bitmap(iconPath.Text);
                }
                catch (Exception)
                {
                }
            }
            return img;
        }

        private void selectIconBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.Title = "Select icon";
            openFileDlg.Multiselect = false;
            openFileDlg.CheckFileExists = true;
            if (openFileDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                iconPath.Text = openFileDlg.FileName;
                if (iconSize.Value == 0)
                {
                    iconSize.Value = 15;
                }
            }
            else
            {
                iconPath.Text = "";
            }
        }

        private void selectIconBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxQRCode_TextChanged(object sender, EventArgs e)
        {
            RenderQrCode();
        }
    }
}