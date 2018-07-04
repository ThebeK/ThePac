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
    public partial class UCMaintainVehicle : UserControl
    {
        public UCMaintainVehicle()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Please fill in all required fields");
            MessageBox.Show("Are you sure you want to update the vehicle details ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Vwhicle details have been updated successfully");



            MessageBox.Show("Are you sure you want to delete this vehicle ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Vehicle details have been deleted successfully");
            MessageBox.Show("This vehicle can not be deleted as it is being used in another transaction, make it unavailable instead ?", "confirmation", MessageBoxButtons.YesNo);
        }
    }
}
