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
    public partial class UCAuditLogReport : UserControl
    {
        public UCAuditLogReport()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please select a user");
            MessageBox.Show("Please Choose a Transaction Type for the report");
        }

        private void UCAuditLogReport_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Add(comboBox1.Text);

        }
    }
}
