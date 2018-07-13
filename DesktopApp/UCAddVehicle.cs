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
    public partial class UCAddVehicle : UserControl
    {
        public UCAddVehicle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to Add this vehicle ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Vehicle details have been added successfully");
            MessageBox.Show("Vehicle already exists on the system");
            MessageBox.Show("Please fill in all required fields");
        }
    }
}
