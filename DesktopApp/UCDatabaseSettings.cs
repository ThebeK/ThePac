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
    public partial class UCDatabaseSettings : UserControl
    {
        public UCDatabaseSettings()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("Are you sure you want to Add this vehicle ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("The following error occured: Cannot open backup device 'C:Users/OneDrive/SmartPac.bak'" );
            MessageBox.Show("Please select a path to make the back up");
            MessageBox.Show("Database: SmartPac backup successfull in C:/Users/Lopac/SmartPac.bak");

            MessageBox.Show("Please select a file called SmartPac.bak'");
            MessageBox.Show("Please select a path to Restore from database");
            MessageBox.Show("Database: SmartPac Restore successfull in C:/Users/Lopac/SmartPac.bak");

        }
    }
}
