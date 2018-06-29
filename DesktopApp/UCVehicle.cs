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
    public partial class UCVehicle : UserControl
    {
        public UCVehicle()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UCAddVehicle addVehicle = new UCAddVehicle();
            panel4.Controls.Add(addVehicle);
            addVehicle.BringToFront();
            addVehicle.Dock = DockStyle.Fill;
        }
    }
}
