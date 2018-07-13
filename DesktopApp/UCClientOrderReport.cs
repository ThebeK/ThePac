using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DesktopApp
{
    public partial class UCClientOrderReport : UserControl
    {
        public UCClientOrderReport()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListBox1.Items.Add(comboBox1.Text);

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Orders obj = ordersBindingSource.Current as Orders;
            if (obj != null)
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "select d.OrderID, p.ProductName, d.Quantity, d.Discount, d.UnitPrice from [Order Details] d inner join Products p on d.ProductID = p.ProductID" +
                                   $" where d.OrderID = '{obj.OrderID}'";
                    List<OrderDetail> list = db.Query<OrderDetail>(query, commandType: CommandType.Text).ToList();

                    using (frmClientOrders frm = new frmClientOrders(obj, list))
                    {
                        frm.ShowDialog();
                    }

                }
            }
        }
    }
}
