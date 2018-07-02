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
    public partial class UCMaintainTemplateFields : UserControl
    {
        public UCMaintainTemplateFields()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Please fill in all required fields");
            MessageBox.Show("Are you sure you want to delete this notification template ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Are you sure you want to update this notification template ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Notification template has been deleted successfully");
            MessageBox.Show("Notification template has been updated successfully");
           
        }
    }
}
