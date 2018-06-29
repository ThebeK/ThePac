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
    public partial class UCNotification1 : UserControl
    {
        public UCNotification1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UCCreateTemplate CreateTemplate = new UCCreateTemplate();
            panel4.Controls.Add(CreateTemplate);
            CreateTemplate.BringToFront();
            CreateTemplate.Dock = DockStyle.Fill;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UCMaintainTemplateFields MaintainTemplate = new UCMaintainTemplateFields();
            panel4.Controls.Add(MaintainTemplate);
            MaintainTemplate.BringToFront();
            MaintainTemplate.Dock = DockStyle.Fill;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UCPublicTemplate PublishTemplate = new UCPublicTemplate();
            panel4.Controls.Add(PublishTemplate);
            PublishTemplate.BringToFront();
            PublishTemplate.Dock = DockStyle.Fill;

        }
    }
}
