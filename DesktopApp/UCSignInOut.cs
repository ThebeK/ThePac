using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.QrCode;
using ZXing.Common;


namespace DesktopApp
{
    public partial class UCSignInOut : UserControl
    {
        public UCSignInOut()
        {
            InitializeComponent();
        }
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        //private ComboBox SelectDevice = new ComboBox();
        //private PictureBox ScanQR = new PictureBox();
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            //splitContainer1.Panel1.Controls.Add(SelectDevice);
            //SelectDevice.Dock = DockStyle.Top;
            //splitContainer1.Panel1.Controls.Add(ScanQR);
            //ScanQR.Dock = DockStyle.Fill;
            try
            {
                pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            catch (Exception ex)
            {

                
            }
            
        }

        private void UCSignInOut_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo device in CaptureDevice)
            {
                comboBox1.Items.Add(device.Name);
            }
            comboBox1.SelectedIndex = -1;
            FinalFrame = new VideoCaptureDevice();



            
            //splitContainer1.Panel2.Enabled = false;
            //textBox1.Text = "";

        }

        private void UCSignInOut_Leave(object sender, EventArgs e)
        {
            if (FinalFrame!=null)
            {
                if (FinalFrame.IsRunning == true)
                {
                    FinalFrame.Stop();
                }
            }
            
        }

        //private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        //{

        //}

        private void timer1_Tick(object sender, EventArgs e)
        {
            QRCodeReader Scanner = new QRCodeReader();
            if (pictureBox1.Image!=null)
            {



                byte[] mybyte = (byte[])new ImageConverter().ConvertTo(pictureBox1.Image, Type.GetType("Byte"));
                LuminanceSource source = new RGBLuminanceSource(mybyte, pictureBox1.Image.Width, pictureBox1.Image.Height);
                var bin = new HybridBinarizer(source);
                var binBit = new BinaryBitmap(bin);
                Result result = Scanner.decode(binBit);

                try
                {
                    string decoded = result.ToString().Trim();
                    if (decoded=="Hello")
                    {
                        MessageBox.Show( decoded);
                        timer1.Stop();
                        
                    }
                    


                    
                    //splitContainer1.Panel2.Enabled = true;
                    //textBox1.Text = decoded;

                }
                catch (Exception ex)
                {

                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            timer1.Enabled = true;
            timer1.Start();
        }

        
    }
}
