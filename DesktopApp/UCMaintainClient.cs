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
    public partial class UCMaintainClient : UserControl
    {
        public UCMaintainClient()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Please fill in all required fields");
            MessageBox.Show("Are you sure you want to update the client details ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Client details have been updated successfully");



            MessageBox.Show("Are you sure you want to delete this Client ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Client details have been deleted successfully");
            MessageBox.Show("This Client is being used by another transaction and cannot be deleted");
        }
    }
}
