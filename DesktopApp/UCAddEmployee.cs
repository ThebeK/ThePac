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
    public partial class UCAddEmployee : UserControl
    {
        public UCAddEmployee()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Are you sure you want to add this employee ?", "confirmation", MessageBoxButtons.YesNo);
            MessageBox.Show("Employee details have been added successfully");
            MessageBox.Show("Employee already exists on the system");
            MessageBox.Show("Please fill in all required fields");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Add employee details first");
        }
    }
}
