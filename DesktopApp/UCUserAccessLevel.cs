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
    public partial class UCUserAccessLevel : UserControl
    {
        public UCUserAccessLevel()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UCUser user = new UCUser();
            panel4.Controls.Add(user);
            user.BringToFront();
            user.Dock = DockStyle.Fill;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            UCAddAccessLevel accessLevel = new UCAddAccessLevel();
            panel4.Controls.Add(accessLevel);
            accessLevel.BringToFront();
            accessLevel.Dock = DockStyle.Fill;

        }
    }
}
