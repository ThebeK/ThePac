using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace DesktopApp
{
    public partial class frmGenerateQR : Form
    {
        public frmGenerateQR()
        {
            InitializeComponent();
            RenderQrCode();
        }
        private void RenderQrCode()
        {

            QRCodeGenerator.ECCLevel eccLevel = (QRCodeGenerator.ECCLevel.L);
            using (QRCodeGenerator qrGenerator = new QRCodeGenerator())
            {
                using (QRCodeData qrCodeData = qrGenerator.CreateQrCode(comboBox1.Text, eccLevel))
                {
                    using (QRCode qrCode = new QRCode(qrCodeData))
                    {

                        pictureBoxQRCode.BackgroundImage = qrCode.GetGraphic(20, Color.Black, Color.White, true);

                        this.pictureBoxQRCode.Size = new System.Drawing.Size(pictureBoxQRCode.Width, pictureBoxQRCode.Height);
                        //Set the SizeMode to center the image.
                        this.pictureBoxQRCode.SizeMode = PictureBoxSizeMode.CenterImage;

                        pictureBoxQRCode.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RenderQrCode();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            RenderQrCode();
        }
    }
}
