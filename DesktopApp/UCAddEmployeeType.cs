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
    public partial class UCAddEmployeeType : UserControl
    {
        public UCAddEmployeeType()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to add this employee type ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Employee type has been added successfully");
            MessageBox.Show("Please fill in all required fields");
        }
    }
}
