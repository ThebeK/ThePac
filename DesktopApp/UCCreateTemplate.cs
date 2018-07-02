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
    public partial class UCCreateTemplate : UserControl
    {
        public UCCreateTemplate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter all required fields");
            MessageBox.Show("Are you sure you want to create this notification ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Email notification template has been created successfully");
        }
    }
}
