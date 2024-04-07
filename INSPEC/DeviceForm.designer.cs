namespace lucidcode.LucidScribe.Plugin.INSPEC
{
  partial class DeviceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceForm));
            this.pnlPlugins = new lucidcode.Controls.Panel3D();
            this.lstDevices = new System.Windows.Forms.ListView();
            this.deviceMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuRefreshPorts = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.Panel3D4 = new lucidcode.Controls.Panel3D();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.panel3D3 = new lucidcode.Controls.Panel3D();
            this.characteristicUuidText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.serviceUuidText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.thresholdText = new System.Windows.Forms.TextBox();
            this.deviceNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.algorithmCombo = new System.Windows.Forms.ComboBox();
            this.panel3D5 = new lucidcode.Controls.Panel3D();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.scanButton = new System.Windows.Forms.Button();
            this.pnlPlugins.SuspendLayout();
            this.deviceMenu.SuspendLayout();
            this.Panel3D4.SuspendLayout();
            this.panel3D3.SuspendLayout();
            this.panel3D5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPlugins
            // 
            this.pnlPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPlugins.BackColor = System.Drawing.Color.White;
            this.pnlPlugins.Controls.Add(this.lstDevices);
            this.pnlPlugins.Controls.Add(this.Panel3D4);
            this.pnlPlugins.Location = new System.Drawing.Point(12, 215);
            this.pnlPlugins.Name = "pnlPlugins";
            this.pnlPlugins.Size = new System.Drawing.Size(409, 292);
            this.pnlPlugins.TabIndex = 5;
            // 
            // lstDevices
            // 
            this.lstDevices.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstDevices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDevices.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstDevices.ContextMenuStrip = this.deviceMenu;
            this.lstDevices.HideSelection = false;
            this.lstDevices.LargeImageList = this.imageList;
            this.lstDevices.Location = new System.Drawing.Point(3, 25);
            this.lstDevices.MultiSelect = false;
            this.lstDevices.Name = "lstDevices";
            this.lstDevices.Size = new System.Drawing.Size(403, 264);
            this.lstDevices.TabIndex = 0;
            this.lstDevices.TileSize = new System.Drawing.Size(150, 32);
            this.lstDevices.UseCompatibleStateImageBehavior = false;
            this.lstDevices.View = System.Windows.Forms.View.Tile;
            this.lstDevices.SelectedIndexChanged += new System.EventHandler(this.lstDevices_SelectedIndexChanged);
            this.lstDevices.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lstDevices_MouseMove);
            // 
            // deviceMenu
            // 
            this.deviceMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRefreshPorts});
            this.deviceMenu.Name = "mnuPortsList";
            this.deviceMenu.Size = new System.Drawing.Size(114, 26);
            // 
            // mnuRefreshPorts
            // 
            this.mnuRefreshPorts.Name = "mnuRefreshPorts";
            this.mnuRefreshPorts.Size = new System.Drawing.Size(113, 22);
            this.mnuRefreshPorts.Text = "&Refresh";
            this.mnuRefreshPorts.Click += new System.EventHandler(this.mnuRefresh_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Graph.Plugin2.bmp");
            // 
            // Panel3D4
            // 
            this.Panel3D4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel3D4.BackColor = System.Drawing.Color.SteelBlue;
            this.Panel3D4.Controls.Add(this.Label5);
            this.Panel3D4.Controls.Add(this.Label6);
            this.Panel3D4.Location = new System.Drawing.Point(0, 0);
            this.Panel3D4.Name = "Panel3D4";
            this.Panel3D4.Size = new System.Drawing.Size(409, 24);
            this.Panel3D4.TabIndex = 4;
            // 
            // Label5
            // 
            this.Label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.Label5.ForeColor = System.Drawing.Color.White;
            this.Label5.Image = ((System.Drawing.Image)(resources.GetObject("Label5.Image")));
            this.Label5.Location = new System.Drawing.Point(3, 3);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(19, 19);
            this.Label5.TabIndex = 4;
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label6
            // 
            this.Label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label6.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.Label6.ForeColor = System.Drawing.Color.White;
            this.Label6.Location = new System.Drawing.Point(24, 3);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(382, 19);
            this.Label6.TabIndex = 3;
            this.Label6.Text = "Devices";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3D3
            // 
            this.panel3D3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3D3.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel3D3.Controls.Add(this.scanButton);
            this.panel3D3.Controls.Add(this.characteristicUuidText);
            this.panel3D3.Controls.Add(this.label8);
            this.panel3D3.Controls.Add(this.serviceUuidText);
            this.panel3D3.Controls.Add(this.label1);
            this.panel3D3.Controls.Add(this.thresholdText);
            this.panel3D3.Controls.Add(this.deviceNameText);
            this.panel3D3.Controls.Add(this.label3);
            this.panel3D3.Controls.Add(this.label7);
            this.panel3D3.Controls.Add(this.label2);
            this.panel3D3.Controls.Add(this.algorithmCombo);
            this.panel3D3.Controls.Add(this.panel3D5);
            this.panel3D3.Location = new System.Drawing.Point(12, 12);
            this.panel3D3.Name = "panel3D3";
            this.panel3D3.Size = new System.Drawing.Size(409, 197);
            this.panel3D3.TabIndex = 284;
            // 
            // characteristicUuidText
            // 
            this.characteristicUuidText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.characteristicUuidText.Location = new System.Drawing.Point(113, 135);
            this.characteristicUuidText.Name = "characteristicUuidText";
            this.characteristicUuidText.Size = new System.Drawing.Size(287, 21);
            this.characteristicUuidText.TabIndex = 5;
            this.characteristicUuidText.TextChanged += new System.EventHandler(this.characteristicUuidText_TextChanged);
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label8.Location = new System.Drawing.Point(3, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 293;
            this.label8.Text = "Characteristic";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // serviceUuidText
            // 
            this.serviceUuidText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serviceUuidText.Location = new System.Drawing.Point(113, 108);
            this.serviceUuidText.Name = "serviceUuidText";
            this.serviceUuidText.Size = new System.Drawing.Size(287, 21);
            this.serviceUuidText.TabIndex = 4;
            this.serviceUuidText.TextChanged += new System.EventHandler(this.serviceUuidText_TextChanged);
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(3, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 291;
            this.label1.Text = "Service UUID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // thresholdText
            // 
            this.thresholdText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.thresholdText.Location = new System.Drawing.Point(113, 54);
            this.thresholdText.Name = "thresholdText";
            this.thresholdText.Size = new System.Drawing.Size(287, 21);
            this.thresholdText.TabIndex = 2;
            this.thresholdText.TextChanged += new System.EventHandler(this.txtThreshold_TextChanged);
            // 
            // deviceNameText
            // 
            this.deviceNameText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deviceNameText.Location = new System.Drawing.Point(113, 81);
            this.deviceNameText.Name = "deviceNameText";
            this.deviceNameText.Size = new System.Drawing.Size(287, 21);
            this.deviceNameText.TabIndex = 3;
            this.deviceNameText.TextChanged += new System.EventHandler(this.deviceNameText_TextChanged);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(3, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 289;
            this.label3.Text = "Device Name";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(3, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 21);
            this.label7.TabIndex = 285;
            this.label7.Text = "Threshold";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(3, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 285;
            this.label2.Text = "Algorithm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // algorithmCombo
            // 
            this.algorithmCombo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.algorithmCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algorithmCombo.FormattingEnabled = true;
            this.algorithmCombo.Items.AddRange(new object[] {
            "Motion Detection"});
            this.algorithmCombo.Location = new System.Drawing.Point(113, 27);
            this.algorithmCombo.Name = "algorithmCombo";
            this.algorithmCombo.Size = new System.Drawing.Size(287, 21);
            this.algorithmCombo.TabIndex = 1;
            this.algorithmCombo.SelectedIndexChanged += new System.EventHandler(this.cmbAlgorithm_SelectedIndexChanged);
            // 
            // panel3D5
            // 
            this.panel3D5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3D5.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3D5.Controls.Add(this.label4);
            this.panel3D5.Controls.Add(this.label11);
            this.panel3D5.Location = new System.Drawing.Point(0, 0);
            this.panel3D5.Name = "panel3D5";
            this.panel3D5.Size = new System.Drawing.Size(409, 24);
            this.panel3D5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 19);
            this.label4.TabIndex = 4;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(24, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(382, 19);
            this.label11.TabIndex = 3;
            this.label11.Text = "Settings";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // scanButton
            // 
            this.scanButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.scanButton.Location = new System.Drawing.Point(317, 162);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(83, 23);
            this.scanButton.TabIndex = 294;
            this.scanButton.Text = "Scan";
            this.scanButton.UseVisualStyleBackColor = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(433, 519);
            this.Controls.Add(this.panel3D3);
            this.Controls.Add(this.pnlPlugins);
            this.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeviceForm";
            this.Text = "Lucid Scribe - INSPEC";
            this.Load += new System.EventHandler(this.PortForm_Load);
            this.pnlPlugins.ResumeLayout(false);
            this.deviceMenu.ResumeLayout(false);
            this.Panel3D4.ResumeLayout(false);
            this.panel3D3.ResumeLayout(false);
            this.panel3D3.PerformLayout();
            this.panel3D5.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    internal lucidcode.Controls.Panel3D pnlPlugins;
    internal lucidcode.Controls.Panel3D Panel3D4;
    internal System.Windows.Forms.Label Label5;
    internal System.Windows.Forms.Label Label6;
    internal System.Windows.Forms.ListView lstDevices;
    internal System.Windows.Forms.ImageList imageList;
    private System.Windows.Forms.ContextMenuStrip deviceMenu;
    private System.Windows.Forms.ToolStripMenuItem mnuRefreshPorts;
    internal Controls.Panel3D panel3D3;
    internal Controls.Panel3D panel3D5;
    internal System.Windows.Forms.Label label4;
    internal System.Windows.Forms.Label label11;
    internal System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox algorithmCombo;
    private System.Windows.Forms.TextBox thresholdText;
    internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox deviceNameText;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serviceUuidText;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox characteristicUuidText;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button scanButton;
    }
}