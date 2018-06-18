<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmClientOrder.aspx.cs" Inherits="SmartPac_v1._0.frmClientOrder" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Client Purchase Order</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="scripts/jquery-3.3.1.min.js"></script>
    <script src="scripts/bootstrap.min.js"></script>

</head>

<body>

    <nav class="navbar navbar-default">
        <div class="container-fluid">
            <!-- Brand/logo -->
            <a class="navbar navbar-brand" href="#">
                <img class="navbar img-thumbnail" src="Images/SmartPac.jpg" alt="logo" style="width: 100px; align-content: center;" />
            </a>
            <!-- Links -->
            <%--<ul class="nav navbar-nav">
                <li>
                    <a href="#">Link 1</a>
                </li>
                <li>
                    <a href="#">Link 2</a>
                </li>
                <li>
                    <a href="#">Link 3</a>
                </li>
            </ul>--%>
            <div style="text-align:right">Signed in as @Username</div>
            <form class="navbar-form"  style="text-align:center">
                <div class="input-group">
                    <input type="text" class="form-control" placeholder="Search Product" name="search" />
                    <div class="input-group-btn">
                        <button class="btn btn-default" type="submit">
                            <i class="glyphicon glyphicon-search"></i>
                        </button>
                    </div>
                </div>
            </form>
        </div>
    </nav>
    
    <div style="text-align: right">
        <h1 style="text-align: center">Client Purchase Order</h1>
        <button name="checkout" class="btn btn-success">Checkout</button>
        <button name="cancel" class="btn btn-danger">Cancel</button>
    </div>

    <div class="container">
        <a class="btn" href="#"></a>
        <button class="btn btn-default" onclick="listView()"><i class="glyphicon glyphicon-list"></i>List</button>
        <button class="btn btn-default" onclick="gridView()"><i class="glyphicon glyphicon-th-large"></i>Grid</button>
        <div class="row">
            <div class="col-sm-3">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Product 1
                    </div>
                    <div class="panel-body">
                        <img src="Images/SmartPac.jpg" style="width: 100px;" />
                        <ul>
                        </ul>
                    </div>
                    <div class="panel-footer">
                        <div>
                            <b>Price: R0.00</b>
                        </div>
                        <div style="text-align: right">
                            <b>Quantity
                                <input type="number" name="quantity" min="0" /></b>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-sm-3">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Product 1
                    </div>
                    <div class="panel-body">
                        <img src="Images/SmartPac.jpg" style="width: 100px;" />
                        <ul>
                        </ul>
                    </div>
                    <div class="panel-footer">
                        <div>
                            <b>Price: R0.00</b>
                        </div>
                        <div style="text-align: right">
                            <b>Quantity
                                <input type="number" name="quantity" min="0" /></b>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-sm-3">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Product 1
                    </div>
                    <div class="panel-body">
                        <img src="Images/SmartPac.jpg" style="width: 100px;" />
                        <ul>
                        </ul>
                    </div>
                    <div class="panel-footer">
                        <div>
                            <b>Price: R0.00</b>
                        </div>
                        <div style="text-align: right">
                            <b>Quantity
                                <input type="number" name="quantity" min="0" /></b>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-sm-3">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Product 1
                    </div>
                    <div class="panel-body">
                        <img src="Images/SmartPac.jpg" style="width: 100px;" />
                        <ul>
                        </ul>
                    </div>
                    <div class="panel-footer">
                        <div>
                            <b>Price: R0.00</b>
                        </div>
                        <div style="text-align: right">
                            <b>Quantity
                                <input type="number" name="quantity" min="0" /></b>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-3">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Product 1
                    </div>
                    <div class="panel-body">
                        <img src="Images/SmartPac.jpg" style="width: 100px;" />
                        <ul>
                        </ul>
                    </div>
                    <div class="panel-footer">
                        <div>
                            <b>Price: R0.00</b>
                        </div>
                        <div style="text-align: right">
                            <b>Quantity
                                <input type="number" name="quantity" min="0" /></b>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-sm-3">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Product 1
                    </div>
                    <div class="panel-body">
                        <img src="Images/SmartPac.jpg" style="width: 100px;" />
                        <ul>
                        </ul>
                    </div>
                    <div class="panel-footer">
                        <div>
                            <b>Price: R0.00</b>
                        </div>
                        <div style="text-align: right">
                            <b>Quantity
                                <input type="number" name="quantity" min="0" /></b>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-sm-3">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Product 1
                    </div>
                    <div class="panel-body">
                        <img src="Images/SmartPac.jpg" style="width: 100px;" />
                        <ul>
                        </ul>
                    </div>
                    <div class="panel-footer">
                        <div>
                            <b>Price: R0.00</b>
                        </div>
                        <div style="text-align: right">
                            <b>Quantity
                                <input type="number" name="quantity" min="0" /></b>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-sm-3">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Product 1
                    </div>
                    <div class="panel-body">
                        <img src="Images/SmartPac.jpg" style="width: 100px;" />
                        <ul>
                        </ul>
                    </div>
                    <div class="panel-footer">
                        <div>
                            <b>Price: R0.00</b>
                        </div>
                        <div style="text-align: right">
                            <b>Quantity
                                <input type="number" name="quantity" min="0" /></b>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            <div class="col-sm-3">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Product 1
                    </div>
                    <div class="panel-body">
                        <img src="Images/SmartPac.jpg" style="width: 100px;" />
                        <ul>
                        </ul>
                    </div>
                    <div class="panel-footer">
                        <div>
                            <b>Price: R0.00</b>
                        </div>
                        <div style="text-align: right">
                            <b>Quantity
                                <input type="number" name="quantity" min="0" /></b>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-sm-3">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Product 1
                    </div>
                    <div class="panel-body">
                        <img src="Images/SmartPac.jpg" style="width: 100px;" />
                        <ul>
                        </ul>
                    </div>
                    <div class="panel-footer">
                        <div>
                            <b>Price: R0.00</b>
                        </div>
                        <div style="text-align: right">
                            <b>Quantity
                                <input type="number" name="quantity" min="0" /></b>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-sm-3">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Product 1
                    </div>
                    <div class="panel-body">
                        <img src="Images/SmartPac.jpg" style="width: 100px;" />
                        <ul>
                        </ul>
                    </div>
                    <div class="panel-footer">
                        <div>
                            <b>Price: R0.00</b>
                        </div>
                        <div style="text-align: right">
                            <b>Quantity
                                <input type="number" name="quantity" min="0" /></b>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-sm-3">
                <div class="panel panel-default">
                    <div class="panel-heading">
                        Product 1
                    </div>
                    <div class="panel-body">
                        <img src="Images/SmartPac.jpg" style="width: 100px;" />
                        <ul>
                        </ul>
                    </div>
                    <div class="panel-footer">
                        <div>
                            <b>Price: R0.00</b>
                        </div>
                        <div style="text-align: right">
                            <b>Quantity
                                <input type="number" name="quantity" min="0" /></b>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div style="text-align: right">
        <button name="checkout" class="btn btn-success">Checkout</button>
        <button name="cancel" class="btn btn-danger">Cancel</button>
    </div>

    <script>
        // Get the elements with class="column"
        var elements = document.getElementsByClassName("col-sm-3");

        // Declare a loop variable
        var i;

        // List View
        function listView() {
            for (i = 0; i < elements.length; i++) {
                elements[i].style.width = "100%";
            }
        }

        // Grid View
        function gridView() {
            for (i = 0; i < elements.length; i++) {
                elements[i].style.width = "25%";
            }
        }

        /* Optional: Add active class to the current button (highlight it) */
        var container = document.getElementById("btnContainer");
        var btns = container.getElementsByClassName("btn");
        for (var i = 0; i < btns.length; i++) {
            btns[i].addEventListener("click", function () {
                var current = document.getElementsByClassName("active");
                current[0].className = current[0].className.replace(" active", "");
                this.className += " active";
            });
        }
    </script>

    <footer></footer>
</body>

</html>
