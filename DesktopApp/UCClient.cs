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
    public partial class UCClient : UserControl
    {
        public UCClient()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UCAddClient AddClient = new UCAddClient();
            panel4.Controls.Add(AddClient);
            AddClient.BringToFront();
            AddClient.Dock = DockStyle.Fill;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UCMaintainClient MaintainClient = new UCMaintainClient();
            panel4.Controls.Add(MaintainClient);
            MaintainClient.BringToFront();
            MaintainClient.Dock = DockStyle.Fill;
        }
    }
}
