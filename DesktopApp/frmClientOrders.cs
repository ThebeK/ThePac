using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class frmClientOrders : Form
    {
        Orders _Orders;
        List<OrderDetail> _List;
        public frmClientOrders(Orders orders, List<OrderDetail>list)
        {
            InitializeComponent();
            _Orders = orders;
            _List = list;
        }

        private void frmClientOrders_Load(object sender, EventArgs e)
        {
            OrderDetailBindingSource.DataSource = _List;
            Microsoft.Reporting.WinForms.ReportParameter[] p = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pOrderID",_Orders.OrderID.ToString()),
                new Microsoft.Reporting.WinForms.ReportParameter("pOrderDate",_Orders.OrderDate.ToString("MM/dd/yyyy")),
                new Microsoft.Reporting.WinForms.ReportParameter("pContactName",_Orders.ContactName),
                new Microsoft.Reporting.WinForms.ReportParameter("pPostalCode",_Orders.PostalCode),
                new Microsoft.Reporting.WinForms.ReportParameter("pAddress",_Orders.Address),
                new Microsoft.Reporting.WinForms.ReportParameter("pCity",_Orders.City),
                new Microsoft.Reporting.WinForms.ReportParameter("pPhone",_Orders.Phone),
            };
            this.ReportViewerClientOrder.LocalReport.SetParameters(p);
            this.ReportViewerClientOrder.RefreshReport();
        }
    }
}
