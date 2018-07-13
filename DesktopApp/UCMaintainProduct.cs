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
    public partial class UCMaintainProduct : UserControl
    {
        public UCMaintainProduct()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please fill in all required fields");
            MessageBox.Show("Are you sure you want to update the Product details ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Product details have been updated successfully");



            MessageBox.Show("Are you sure you want to delete this Product ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Product details have been deleted successfully");
            MessageBox.Show("This Product can not be deleted as it is being used in another transaction");
        }
    }
}
