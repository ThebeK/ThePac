using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DesktopApp
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        { 

            InitializeComponent();

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(3);
            if(progressBar1.Value==100)
                timer1.Stop();
            
        }

        private void pbxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            
        }
    }
}
