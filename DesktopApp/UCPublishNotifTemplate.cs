using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp.UCNotification
{
    public partial class UCPublishNotifTemplate : UserControl
    {
        public UCPublishNotifTemplate()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select atleast one client");
            MessageBox.Show("Are you sure you want to send this notification ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Email notification has been sent successfully");
         
        }
    }
}
