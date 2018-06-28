<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCheckout.aspx.cs" Inherits="SmartPac_v1._0.frmCheckout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Purchase Order</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="scripts/jquery-3.3.1.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="table-responsive">
                <table class="table">
                    <thead>
                        <tr>
                            <th>Product Name
                            </th>
                            <th>Quantity
                            </th>
                            <th>Unit Price
                            </th>
                            <th>Subtotal
                            </th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>Product 1
                            </td>
                            <td>0
                            </td>
                            <td>0.00
                            </td>
                            <td>0.00
                            </td>
                        </tr>
                    </tbody>
                    <tfoot style="text-align: left;">
                        
                        <tr>
                            
                            <td class="info">Total excl VAT:
                            </td>
                        </tr>
                        <tr>
                            
                            <td class="info">VAT @ 15%:
                            </td>
                        </tr>
                        <tr>
                            
                            <td class="info">Total incl VAT: 
                            </td>
                        </tr>
                    </tfoot>
                </table>
                <div style="text-align:right">
                <button class="btn btn-success"  >Confirm</button>
                <button class="btn btn-danger" >Back</button>
                    </div>
            </div>
        </div>
    </form>
</body>
</html>
