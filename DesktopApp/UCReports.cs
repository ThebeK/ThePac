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
    public partial class UCReports : UserControl
    {
        public UCReports()
        {
            InitializeComponent();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            UCSalesReport SalesReport = new UCSalesReport();
            panel4.Controls.Add(SalesReport);
            SalesReport.BringToFront();
            SalesReport.Dock = DockStyle.Fill;
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

            UCProductReport ProductReport = new UCProductReport();
            panel4.Controls.Add(ProductReport);
            ProductReport.BringToFront();
            ProductReport.Dock = DockStyle.Fill;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            UCCreditReturnReport CreditRetReport = new UCCreditReturnReport();
            panel4.Controls.Add(CreditRetReport);
            CreditRetReport.BringToFront();
            CreditRetReport.Dock = DockStyle.Fill;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            UCEmployeeReport EmployeeReport = new UCEmployeeReport();
            panel4.Controls.Add(EmployeeReport);
            EmployeeReport.BringToFront();
            EmployeeReport.Dock = DockStyle.Fill;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            UCOrderReport OrderReport = new UCOrderReport();
            panel4.Controls.Add(OrderReport);
            OrderReport.BringToFront();
            OrderReport.Dock = DockStyle.Fill;
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            UCAuditTrailReport AuditTrailReport = new UCAuditTrailReport();
            panel4.Controls.Add(AuditTrailReport);
            AuditTrailReport.BringToFront();
            AuditTrailReport.Dock = DockStyle.Fill;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UCOutstandingDeliveriesReport OutDelReport = new UCOutstandingDeliveriesReport();
            panel4.Controls.Add(OutDelReport);
            OutDelReport.BringToFront();
            OutDelReport.Dock = DockStyle.Fill;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            UCEmployeeReport EmployeeReport = new UCEmployeeReport();
            panel4.Controls.Add(EmployeeReport);
            EmployeeReport.BringToFront();
            EmployeeReport.Dock = DockStyle.Fill;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            UCOrderReport OrderReprt = new UCOrderReport();
            panel4.Controls.Add(OrderReprt);
            OrderReprt.BringToFront();
            OrderReprt.Dock = DockStyle.Fill;
        }
    }
}
