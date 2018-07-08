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
    public partial class UCAddClient : UserControl
    {
        public UCAddClient()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Are you sure you want to add this client ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Client details have been added successfully");
            MessageBox.Show("Client already exists on the system");
            MessageBox.Show("Please fill in all required fields");

        }
    }
}
