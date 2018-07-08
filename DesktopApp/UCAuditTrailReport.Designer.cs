namespace DesktopApp
{
    partial class UCAuditTrailReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
          //  Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
         //   this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.smartpac_reportsDataSet = new DesktopApp.smartpac_reportsDataSet();
            this.SalesReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.SalesReportTableAdapter = new DesktopApp.smartpac_reportsDataSetTableAdapters.SalesReportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.smartpac_reportsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Audit Trail Report";
            // 
            // reportViewer1
            // 
            //reportDataSource1.Name = "DataSet1";
            //reportDataSource1.Value = this.SalesReportBindingSource;
            //this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            //this.reportViewer1.Location = new System.Drawing.Point(192, 139);
            //this.reportViewer1.Name = "reportViewer1";
            //this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            //this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            //this.reportViewer1.TabIndex = 17;
            // 
            // smartpac_reportsDataSet
            // 
            this.smartpac_reportsDataSet.DataSetName = "smartpac_reportsDataSet";
            this.smartpac_reportsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SalesReportBindingSource
            // 
            this.SalesReportBindingSource.DataMember = "SalesReport";
            this.SalesReportBindingSource.DataSource = this.smartpac_reportsDataSet;
            // 
            // SalesReportTableAdapter
            // 
            this.SalesReportTableAdapter.ClearBeforeFill = true;
            // 
            // UCClientReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          //  this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Name = "UCClientReport";
            this.Size = new System.Drawing.Size(821, 507);
            ((System.ComponentModel.ISupportInitialize)(this.smartpac_reportsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
       // private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SalesReportBindingSource;
        private smartpac_reportsDataSet smartpac_reportsDataSet;
        private smartpac_reportsDataSetTableAdapters.SalesReportTableAdapter SalesReportTableAdapter;
    }
}
