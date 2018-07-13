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
    public partial class UCCreditReturnReport : UserControl
    {
        public UCCreditReturnReport()
        {
            InitializeComponent();
        }

        private void UCCreditReturnReport_Load(object sender, EventArgs e)
        {
            chartCreditReturn.Series["CreditReturn"].Points.AddXY("Invoice Quantity Overstated", 4);
            chartCreditReturn.Series["CreditReturn"].Points.AddXY("Damaged", 2);
            chartCreditReturn.Series["CreditReturn"].Points.AddXY("Late Delivery", 6);
            chartCreditReturn.Series["CreditReturn"].Points.AddXY("Stock Short Delivered", 3);
        }
    }
}
