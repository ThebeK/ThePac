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
    public partial class UCMaintainEmployeeType : UserControl
    {
        public UCMaintainEmployeeType()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please fill in all required fields");
            MessageBox.Show("Are you sure you want to update the Employee Type details ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Employee Type details have been updated successfully");



            MessageBox.Show("Are you sure you want to delete this Employee Type ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Employee Type details have been deleted successfully");
            MessageBox.Show("This Employee Type can not be deleted as it is being used in another transaction");
        }
    }
}
