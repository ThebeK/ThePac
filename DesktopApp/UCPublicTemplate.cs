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
    public partial class UCPublicTemplate : UserControl
    {
        public UCPublicTemplate()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UCNotification.UCPublishNotifTemplate publish = new UCNotification.UCPublishNotifTemplate();
            panel1.Controls.Clear();
            panel1.Controls.Add(publish);
            publish.BringToFront();
            publish.Dock = DockStyle.Fill;
        }
    }
}
