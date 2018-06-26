namespace DesktopApp
{
    partial class frmCreditReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreditReturn));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbxMin = new System.Windows.Forms.PictureBox();
            this.pbxMaxNorm = new System.Windows.Forms.PictureBox();
            this.pbxClose = new System.Windows.Forms.PictureBox();
            this.imlMaxNorm = new System.Windows.Forms.ImageList(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaxNorm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.pbxMin);
            this.panel2.Controls.Add(this.pbxMaxNorm);
            this.panel2.Controls.Add(this.pbxClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 40);
            this.panel2.TabIndex = 3;
            // 
            // pbxMin
            // 
            this.pbxMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMin.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbxMin.Image = ((System.Drawing.Image)(resources.GetObject("pbxMin.Image")));
            this.pbxMin.Location = new System.Drawing.Point(338, 3);
            this.pbxMin.Name = "pbxMin";
            this.pbxMin.Size = new System.Drawing.Size(30, 30);
            this.pbxMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMin.TabIndex = 11;
            this.pbxMin.TabStop = false;
            this.pbxMin.Click += new System.EventHandler(this.pbxMin_Click);
            // 
            // pbxMaxNorm
            // 
            this.pbxMaxNorm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMaxNorm.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbxMaxNorm.Image = ((System.Drawing.Image)(resources.GetObject("pbxMaxNorm.Image")));
            this.pbxMaxNorm.Location = new System.Drawing.Point(374, 3);
            this.pbxMaxNorm.Name = "pbxMaxNorm";
            this.pbxMaxNorm.Size = new System.Drawing.Size(30, 30);
            this.pbxMaxNorm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMaxNorm.TabIndex = 10;
            this.pbxMaxNorm.TabStop = false;
            this.pbxMaxNorm.Click += new System.EventHandler(this.pbxMaxNorm_Click);
            // 
            // pbxClose
            // 
            this.pbxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxClose.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbxClose.Image = ((System.Drawing.Image)(resources.GetObject("pbxClose.Image")));
            this.pbxClose.Location = new System.Drawing.Point(410, 3);
            this.pbxClose.Name = "pbxClose";
            this.pbxClose.Size = new System.Drawing.Size(30, 30);
            this.pbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxClose.TabIndex = 9;
            this.pbxClose.TabStop = false;
            this.pbxClose.Click += new System.EventHandler(this.pbxClose_Click);
            // 
            // imlMaxNorm
            // 
            this.imlMaxNorm.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlMaxNorm.ImageStream")));
            this.imlMaxNorm.TransparentColor = System.Drawing.Color.Transparent;
            this.imlMaxNorm.Images.SetKeyName(0, "Maximise.png");
            this.imlMaxNorm.Images.SetKeyName(1, "Normal.png");
            // 
            // frmCreditReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 430);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCreditReturn";
            this.Text = "frmBackOrder";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaxNorm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbxMin;
        private System.Windows.Forms.PictureBox pbxMaxNorm;
        private System.Windows.Forms.PictureBox pbxClose;
        private System.Windows.Forms.ImageList imlMaxNorm;
    }
}