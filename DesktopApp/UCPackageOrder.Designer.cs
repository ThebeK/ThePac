namespace DesktopApp
{
    partial class UCPackageOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBoxQRCode = new System.Windows.Forms.PictureBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxQRCode = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelIcon = new System.Windows.Forms.Label();
            this.selectIconBtn = new System.Windows.Forms.Button();
            this.iconPath = new System.Windows.Forms.TextBox();
            this.iconSize = new System.Windows.Forms.NumericUpDown();
            this.labelIconsize = new System.Windows.Forms.Label();
            this.comboBoxECC = new System.Windows.Forms.ComboBox();
            this.labelECC = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 384);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Package Order";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 83);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(383, 301);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(23, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 337);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Orders to be packaged";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelIcon);
            this.groupBox2.Controls.Add(this.iconSize);
            this.groupBox2.Controls.Add(this.labelIconsize);
            this.groupBox2.Controls.Add(this.labelECC);
            this.groupBox2.Controls.Add(this.iconPath);
            this.groupBox2.Controls.Add(this.comboBoxECC);
            this.groupBox2.Controls.Add(this.textBoxQRCode);
            this.groupBox2.Controls.Add(this.buttonGenerate);
            this.groupBox2.Controls.Add(this.buttonSave);
            this.groupBox2.Controls.Add(this.selectIconBtn);
            this.groupBox2.Controls.Add(this.pictureBoxQRCode);
            this.groupBox2.Location = new System.Drawing.Point(424, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 331);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "QR Code Generated";
            // 
            // pictureBoxQRCode
            // 
            this.pictureBoxQRCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxQRCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxQRCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxQRCode.Location = new System.Drawing.Point(28, 79);
            this.pictureBoxQRCode.Name = "pictureBoxQRCode";
            this.pictureBoxQRCode.Size = new System.Drawing.Size(205, 215);
            this.pictureBoxQRCode.TabIndex = 3;
            this.pictureBoxQRCode.TabStop = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(28, 300);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(92, 25);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save QR code";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBoxQRCode
            // 
            this.textBoxQRCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQRCode.Location = new System.Drawing.Point(28, 31);
            this.textBoxQRCode.Name = "textBoxQRCode";
            this.textBoxQRCode.Size = new System.Drawing.Size(264, 20);
            this.textBoxQRCode.TabIndex = 13;
            this.textBoxQRCode.Text = "1234567890";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerate.Location = new System.Drawing.Point(309, 28);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(62, 23);
            this.buttonGenerate.TabIndex = 12;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // labelIcon
            // 
            this.labelIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIcon.AutoSize = true;
            this.labelIcon.Location = new System.Drawing.Point(243, 194);
            this.labelIcon.Name = "labelIcon";
            this.labelIcon.Size = new System.Drawing.Size(31, 13);
            this.labelIcon.TabIndex = 16;
            this.labelIcon.Text = "Icon:";
            this.labelIcon.Visible = false;
            // 
            // selectIconBtn
            // 
            this.selectIconBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectIconBtn.Location = new System.Drawing.Point(310, 300);
            this.selectIconBtn.Name = "selectIconBtn";
            this.selectIconBtn.Size = new System.Drawing.Size(61, 25);
            this.selectIconBtn.TabIndex = 18;
            this.selectIconBtn.Text = "Select";
            this.selectIconBtn.UseVisualStyleBackColor = true;
            this.selectIconBtn.Visible = false;
            // 
            // iconPath
            // 
            this.iconPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconPath.Location = new System.Drawing.Point(246, 210);
            this.iconPath.Name = "iconPath";
            this.iconPath.Size = new System.Drawing.Size(148, 20);
            this.iconPath.TabIndex = 17;
            this.iconPath.Visible = false;
            // 
            // iconSize
            // 
            this.iconSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iconSize.Location = new System.Drawing.Point(246, 258);
            this.iconSize.Name = "iconSize";
            this.iconSize.Size = new System.Drawing.Size(125, 20);
            this.iconSize.TabIndex = 20;
            this.iconSize.Visible = false;
            // 
            // labelIconsize
            // 
            this.labelIconsize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelIconsize.AutoSize = true;
            this.labelIconsize.Location = new System.Drawing.Point(243, 233);
            this.labelIconsize.Name = "labelIconsize";
            this.labelIconsize.Size = new System.Drawing.Size(52, 13);
            this.labelIconsize.TabIndex = 19;
            this.labelIconsize.Text = "Icon size:";
            this.labelIconsize.Visible = false;
            // 
            // comboBoxECC
            // 
            this.comboBoxECC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxECC.FormattingEnabled = true;
            this.comboBoxECC.Items.AddRange(new object[] {
            "L",
            "M",
            "Q",
            "H"});
            this.comboBoxECC.Location = new System.Drawing.Point(86, 52);
            this.comboBoxECC.Name = "comboBoxECC";
            this.comboBoxECC.Size = new System.Drawing.Size(125, 21);
            this.comboBoxECC.TabIndex = 14;
            this.comboBoxECC.Visible = false;
            // 
            // labelECC
            // 
            this.labelECC.AutoSize = true;
            this.labelECC.Location = new System.Drawing.Point(26, 55);
            this.labelECC.Name = "labelECC";
            this.labelECC.Size = new System.Drawing.Size(57, 13);
            this.labelECC.TabIndex = 15;
            this.labelECC.Text = "ECC-Level";
            this.labelECC.Visible = false;
            // 
            // UCPackageOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "UCPackageOrder";
            this.Size = new System.Drawing.Size(834, 467);
            this.Load += new System.EventHandler(this.UCPackageOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxQRCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBoxQRCode;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxQRCode;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelIcon;
        private System.Windows.Forms.NumericUpDown iconSize;
        private System.Windows.Forms.Label labelIconsize;
        private System.Windows.Forms.Label labelECC;
        private System.Windows.Forms.TextBox iconPath;
        private System.Windows.Forms.ComboBox comboBoxECC;
        private System.Windows.Forms.Button selectIconBtn;
    }
}
