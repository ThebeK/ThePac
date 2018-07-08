namespace DesktopApp
{
    partial class frmClientOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ReportViewerClientOrder = new Microsoft.Reporting.WinForms.ReportViewer();
            this.OrderDetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ReportViewerClientOrder
            // 
            reportDataSource2.Name = "OrderDetails";
            reportDataSource2.Value = this.OrderDetailBindingSource;
            this.ReportViewerClientOrder.LocalReport.DataSources.Add(reportDataSource2);
            this.ReportViewerClientOrder.LocalReport.ReportEmbeddedResource = "DesktopApp.rptClientOrders.rdlc";
            this.ReportViewerClientOrder.Location = new System.Drawing.Point(-4, 12);
            this.ReportViewerClientOrder.Name = "ReportViewerClientOrder";
            this.ReportViewerClientOrder.Size = new System.Drawing.Size(666, 393);
            this.ReportViewerClientOrder.TabIndex = 0;
            // 
            // OrderDetailBindingSource
            // 
            this.OrderDetailBindingSource.DataMember = "OrderDetail";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmClientOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 440);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReportViewerClientOrder);
            this.Name = "frmClientOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ClientOrders";
            this.Load += new System.EventHandler(this.frmClientOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ReportViewerClientOrder;
        private System.Windows.Forms.BindingSource OrderDetailBindingSource;
        private System.Windows.Forms.Button button1;
    }
}