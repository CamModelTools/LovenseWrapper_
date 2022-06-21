
namespace TestApp
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.BtnSearchToys = new System.Windows.Forms.Button();
            this.TxbLog = new System.Windows.Forms.TextBox();
            this.BtnStopSearch = new System.Windows.Forms.Button();
            this.BtnConnectToToy = new System.Windows.Forms.Button();
            this.BtnFlash = new System.Windows.Forms.Button();
            this.BtnPowerOff = new System.Windows.Forms.Button();
            this.BtnDisconnectFromToy = new System.Windows.Forms.Button();
            this.BtnGetBattery = new System.Windows.Forms.Button();
            this.CmbToys = new System.Windows.Forms.ComboBox();
            this.CmbCommands = new System.Windows.Forms.ComboBox();
            this.TrbLevel = new System.Windows.Forms.TrackBar();
            this.BtnGo = new System.Windows.Forms.Button();
            this.PbxToy = new System.Windows.Forms.PictureBox();
            this.ImlToyIcons = new System.Windows.Forms.ImageList(this.components);
            this.BtnStatus = new System.Windows.Forms.Button();
            this.LblToysFound = new System.Windows.Forms.Label();
            this.LblCommands = new System.Windows.Forms.Label();
            this.LblToysCount = new System.Windows.Forms.Label();
            this.TxbToysCount = new System.Windows.Forms.TextBox();
            this.GpbToyManagement = new System.Windows.Forms.GroupBox();
            this.GpbConnectToys = new System.Windows.Forms.GroupBox();
            this.LblBatteryLevel = new System.Windows.Forms.Label();
            this.PgbBatteryLevel = new System.Windows.Forms.ProgressBar();
            this.GpbToyCommands = new System.Windows.Forms.GroupBox();
            this.LblSetLevel = new System.Windows.Forms.Label();
            this.TxbLevel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TrbLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxToy)).BeginInit();
            this.GpbToyManagement.SuspendLayout();
            this.GpbConnectToys.SuspendLayout();
            this.GpbToyCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSearchToys
            // 
            this.BtnSearchToys.Location = new System.Drawing.Point(6, 22);
            this.BtnSearchToys.Name = "BtnSearchToys";
            this.BtnSearchToys.Size = new System.Drawing.Size(150, 23);
            this.BtnSearchToys.TabIndex = 2;
            this.BtnSearchToys.Text = "Search Toys";
            this.BtnSearchToys.UseVisualStyleBackColor = true;
            this.BtnSearchToys.Click += new System.EventHandler(this.BtnSearchToys_Click);
            // 
            // TxbLog
            // 
            this.TxbLog.Location = new System.Drawing.Point(535, 12);
            this.TxbLog.Multiline = true;
            this.TxbLog.Name = "TxbLog";
            this.TxbLog.ReadOnly = true;
            this.TxbLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxbLog.Size = new System.Drawing.Size(357, 323);
            this.TxbLog.TabIndex = 3;
            this.TxbLog.WordWrap = false;
            // 
            // BtnStopSearch
            // 
            this.BtnStopSearch.Enabled = false;
            this.BtnStopSearch.Location = new System.Drawing.Point(162, 22);
            this.BtnStopSearch.Name = "BtnStopSearch";
            this.BtnStopSearch.Size = new System.Drawing.Size(150, 23);
            this.BtnStopSearch.TabIndex = 4;
            this.BtnStopSearch.Text = "Stop Search";
            this.BtnStopSearch.UseVisualStyleBackColor = true;
            this.BtnStopSearch.Click += new System.EventHandler(this.BtnStopSearch_Click);
            // 
            // BtnConnectToToy
            // 
            this.BtnConnectToToy.Enabled = false;
            this.BtnConnectToToy.Location = new System.Drawing.Point(122, 57);
            this.BtnConnectToToy.Name = "BtnConnectToToy";
            this.BtnConnectToToy.Size = new System.Drawing.Size(150, 23);
            this.BtnConnectToToy.TabIndex = 5;
            this.BtnConnectToToy.Text = "Connect to Toy";
            this.BtnConnectToToy.UseVisualStyleBackColor = true;
            this.BtnConnectToToy.Click += new System.EventHandler(this.BtnConnectToToy_Click);
            // 
            // BtnFlash
            // 
            this.BtnFlash.Enabled = false;
            this.BtnFlash.Location = new System.Drawing.Point(122, 18);
            this.BtnFlash.Name = "BtnFlash";
            this.BtnFlash.Size = new System.Drawing.Size(150, 23);
            this.BtnFlash.TabIndex = 6;
            this.BtnFlash.Text = "Flash";
            this.BtnFlash.UseVisualStyleBackColor = true;
            this.BtnFlash.Click += new System.EventHandler(this.BtnFlash_Click);
            // 
            // BtnPowerOff
            // 
            this.BtnPowerOff.Enabled = false;
            this.BtnPowerOff.Location = new System.Drawing.Point(278, 18);
            this.BtnPowerOff.Name = "BtnPowerOff";
            this.BtnPowerOff.Size = new System.Drawing.Size(150, 23);
            this.BtnPowerOff.TabIndex = 7;
            this.BtnPowerOff.Text = "Power Off";
            this.BtnPowerOff.UseVisualStyleBackColor = true;
            this.BtnPowerOff.Click += new System.EventHandler(this.BtnPowerOff_Click);
            // 
            // BtnDisconnectFromToy
            // 
            this.BtnDisconnectFromToy.Enabled = false;
            this.BtnDisconnectFromToy.Location = new System.Drawing.Point(278, 57);
            this.BtnDisconnectFromToy.Name = "BtnDisconnectFromToy";
            this.BtnDisconnectFromToy.Size = new System.Drawing.Size(150, 23);
            this.BtnDisconnectFromToy.TabIndex = 8;
            this.BtnDisconnectFromToy.Text = "Disconnect from Toy";
            this.BtnDisconnectFromToy.UseVisualStyleBackColor = true;
            this.BtnDisconnectFromToy.Click += new System.EventHandler(this.BtnDisconnectFromToy_Click);
            // 
            // BtnGetBattery
            // 
            this.BtnGetBattery.Enabled = false;
            this.BtnGetBattery.Location = new System.Drawing.Point(434, 57);
            this.BtnGetBattery.Name = "BtnGetBattery";
            this.BtnGetBattery.Size = new System.Drawing.Size(75, 23);
            this.BtnGetBattery.TabIndex = 9;
            this.BtnGetBattery.Text = "Battery";
            this.BtnGetBattery.UseVisualStyleBackColor = true;
            this.BtnGetBattery.Click += new System.EventHandler(this.BtnGetBattery_Click);
            // 
            // CmbToys
            // 
            this.CmbToys.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbToys.FormattingEnabled = true;
            this.CmbToys.Location = new System.Drawing.Point(122, 28);
            this.CmbToys.Name = "CmbToys";
            this.CmbToys.Size = new System.Drawing.Size(306, 23);
            this.CmbToys.TabIndex = 10;
            this.CmbToys.SelectedIndexChanged += new System.EventHandler(this.CmbToys_SelectedIndexChanged);
            this.CmbToys.TextChanged += new System.EventHandler(this.CmbToys_TextChanged);
            // 
            // CmbCommands
            // 
            this.CmbCommands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbCommands.FormattingEnabled = true;
            this.CmbCommands.Location = new System.Drawing.Point(122, 47);
            this.CmbCommands.Name = "CmbCommands";
            this.CmbCommands.Size = new System.Drawing.Size(306, 23);
            this.CmbCommands.TabIndex = 11;
            this.CmbCommands.SelectedIndexChanged += new System.EventHandler(this.CmbCommands_SelectedIndexChanged);
            // 
            // TrbLevel
            // 
            this.TrbLevel.Enabled = false;
            this.TrbLevel.Location = new System.Drawing.Point(122, 76);
            this.TrbLevel.Maximum = 0;
            this.TrbLevel.Name = "TrbLevel";
            this.TrbLevel.Size = new System.Drawing.Size(387, 45);
            this.TrbLevel.TabIndex = 12;
            this.TrbLevel.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.TrbLevel.Scroll += new System.EventHandler(this.TrbLevel_Scroll);
            // 
            // BtnGo
            // 
            this.BtnGo.Enabled = false;
            this.BtnGo.Location = new System.Drawing.Point(434, 46);
            this.BtnGo.Name = "BtnGo";
            this.BtnGo.Size = new System.Drawing.Size(75, 23);
            this.BtnGo.TabIndex = 13;
            this.BtnGo.Text = "Go!";
            this.BtnGo.UseVisualStyleBackColor = true;
            this.BtnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // PbxToy
            // 
            this.PbxToy.Location = new System.Drawing.Point(434, 26);
            this.PbxToy.Name = "PbxToy";
            this.PbxToy.Size = new System.Drawing.Size(25, 25);
            this.PbxToy.TabIndex = 14;
            this.PbxToy.TabStop = false;
            // 
            // ImlToyIcons
            // 
            this.ImlToyIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImlToyIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImlToyIcons.ImageStream")));
            this.ImlToyIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.ImlToyIcons.Images.SetKeyName(0, "ambi.png");
            this.ImlToyIcons.Images.SetKeyName(1, "calor.png");
            this.ImlToyIcons.Images.SetKeyName(2, "diamo.png");
            this.ImlToyIcons.Images.SetKeyName(3, "dolce.png");
            this.ImlToyIcons.Images.SetKeyName(4, "domi.png");
            this.ImlToyIcons.Images.SetKeyName(5, "edge.png");
            this.ImlToyIcons.Images.SetKeyName(6, "Exomoon.png");
            this.ImlToyIcons.Images.SetKeyName(7, "Ferri.png");
            this.ImlToyIcons.Images.SetKeyName(8, "gush.png");
            this.ImlToyIcons.Images.SetKeyName(9, "hyphy.png");
            this.ImlToyIcons.Images.SetKeyName(10, "hush.png");
            this.ImlToyIcons.Images.SetKeyName(11, "lush.png");
            this.ImlToyIcons.Images.SetKeyName(12, "max.png");
            this.ImlToyIcons.Images.SetKeyName(13, "mission.png");
            this.ImlToyIcons.Images.SetKeyName(14, "Nora.png");
            this.ImlToyIcons.Images.SetKeyName(15, "osci.png");
            this.ImlToyIcons.Images.SetKeyName(16, "xmachine.png");
            // 
            // BtnStatus
            // 
            this.BtnStatus.Enabled = false;
            this.BtnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStatus.Location = new System.Drawing.Point(465, 28);
            this.BtnStatus.Name = "BtnStatus";
            this.BtnStatus.Size = new System.Drawing.Size(23, 23);
            this.BtnStatus.TabIndex = 15;
            this.BtnStatus.UseVisualStyleBackColor = true;
            // 
            // LblToysFound
            // 
            this.LblToysFound.AutoSize = true;
            this.LblToysFound.Location = new System.Drawing.Point(6, 32);
            this.LblToysFound.Name = "LblToysFound";
            this.LblToysFound.Size = new System.Drawing.Size(65, 15);
            this.LblToysFound.TabIndex = 16;
            this.LblToysFound.Text = "Toys found";
            // 
            // LblCommands
            // 
            this.LblCommands.AutoSize = true;
            this.LblCommands.Location = new System.Drawing.Point(6, 50);
            this.LblCommands.Name = "LblCommands";
            this.LblCommands.Size = new System.Drawing.Size(113, 15);
            this.LblCommands.TabIndex = 17;
            this.LblCommands.Text = "Possible commands";
            // 
            // LblToysCount
            // 
            this.LblToysCount.AutoSize = true;
            this.LblToysCount.Location = new System.Drawing.Point(6, 54);
            this.LblToysCount.Name = "LblToysCount";
            this.LblToysCount.Size = new System.Drawing.Size(88, 15);
            this.LblToysCount.TabIndex = 18;
            this.LblToysCount.Text = "# of toys found";
            // 
            // TxbToysCount
            // 
            this.TxbToysCount.Location = new System.Drawing.Point(162, 51);
            this.TxbToysCount.Name = "TxbToysCount";
            this.TxbToysCount.ReadOnly = true;
            this.TxbToysCount.Size = new System.Drawing.Size(60, 23);
            this.TxbToysCount.TabIndex = 19;
            this.TxbToysCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GpbToyManagement
            // 
            this.GpbToyManagement.Controls.Add(this.BtnSearchToys);
            this.GpbToyManagement.Controls.Add(this.TxbToysCount);
            this.GpbToyManagement.Controls.Add(this.BtnStopSearch);
            this.GpbToyManagement.Controls.Add(this.LblToysCount);
            this.GpbToyManagement.Location = new System.Drawing.Point(12, 12);
            this.GpbToyManagement.Name = "GpbToyManagement";
            this.GpbToyManagement.Size = new System.Drawing.Size(517, 87);
            this.GpbToyManagement.TabIndex = 20;
            this.GpbToyManagement.TabStop = false;
            this.GpbToyManagement.Text = "Toy Management";
            // 
            // GpbConnectToys
            // 
            this.GpbConnectToys.Controls.Add(this.LblBatteryLevel);
            this.GpbConnectToys.Controls.Add(this.PgbBatteryLevel);
            this.GpbConnectToys.Controls.Add(this.LblToysFound);
            this.GpbConnectToys.Controls.Add(this.BtnConnectToToy);
            this.GpbConnectToys.Controls.Add(this.BtnDisconnectFromToy);
            this.GpbConnectToys.Controls.Add(this.BtnGetBattery);
            this.GpbConnectToys.Controls.Add(this.BtnStatus);
            this.GpbConnectToys.Controls.Add(this.CmbToys);
            this.GpbConnectToys.Controls.Add(this.PbxToy);
            this.GpbConnectToys.Enabled = false;
            this.GpbConnectToys.Location = new System.Drawing.Point(12, 105);
            this.GpbConnectToys.Name = "GpbConnectToys";
            this.GpbConnectToys.Size = new System.Drawing.Size(517, 155);
            this.GpbConnectToys.TabIndex = 21;
            this.GpbConnectToys.TabStop = false;
            this.GpbConnectToys.Text = "Toy Connections";
            // 
            // LblBatteryLevel
            // 
            this.LblBatteryLevel.AutoSize = true;
            this.LblBatteryLevel.Location = new System.Drawing.Point(122, 108);
            this.LblBatteryLevel.Name = "LblBatteryLevel";
            this.LblBatteryLevel.Size = new System.Drawing.Size(0, 15);
            this.LblBatteryLevel.TabIndex = 18;
            // 
            // PgbBatteryLevel
            // 
            this.PgbBatteryLevel.Location = new System.Drawing.Point(122, 126);
            this.PgbBatteryLevel.MarqueeAnimationSpeed = 0;
            this.PgbBatteryLevel.Name = "PgbBatteryLevel";
            this.PgbBatteryLevel.Size = new System.Drawing.Size(387, 23);
            this.PgbBatteryLevel.Step = 100;
            this.PgbBatteryLevel.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PgbBatteryLevel.TabIndex = 17;
            // 
            // GpbToyCommands
            // 
            this.GpbToyCommands.Controls.Add(this.LblSetLevel);
            this.GpbToyCommands.Controls.Add(this.LblCommands);
            this.GpbToyCommands.Controls.Add(this.BtnFlash);
            this.GpbToyCommands.Controls.Add(this.BtnPowerOff);
            this.GpbToyCommands.Controls.Add(this.CmbCommands);
            this.GpbToyCommands.Controls.Add(this.BtnGo);
            this.GpbToyCommands.Controls.Add(this.TrbLevel);
            this.GpbToyCommands.Enabled = false;
            this.GpbToyCommands.Location = new System.Drawing.Point(12, 277);
            this.GpbToyCommands.Name = "GpbToyCommands";
            this.GpbToyCommands.Size = new System.Drawing.Size(517, 127);
            this.GpbToyCommands.TabIndex = 22;
            this.GpbToyCommands.TabStop = false;
            this.GpbToyCommands.Text = "Toy Commands";
            // 
            // LblSetLevel
            // 
            this.LblSetLevel.AutoSize = true;
            this.LblSetLevel.Location = new System.Drawing.Point(6, 76);
            this.LblSetLevel.Name = "LblSetLevel";
            this.LblSetLevel.Size = new System.Drawing.Size(116, 15);
            this.LblSetLevel.TabIndex = 18;
            this.LblSetLevel.Text = "Set Level and send ...";
            // 
            // TxbLevel
            // 
            this.TxbLevel.Location = new System.Drawing.Point(535, 364);
            this.TxbLevel.Name = "TxbLevel";
            this.TxbLevel.ReadOnly = true;
            this.TxbLevel.Size = new System.Drawing.Size(60, 23);
            this.TxbLevel.TabIndex = 20;
            this.TxbLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 416);
            this.Controls.Add(this.TxbLevel);
            this.Controls.Add(this.GpbToyCommands);
            this.Controls.Add(this.GpbConnectToys);
            this.Controls.Add(this.GpbToyManagement);
            this.Controls.Add(this.TxbLog);
            this.Name = "FrmMain";
            this.Text = "Test Lovense Toys";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.TrbLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbxToy)).EndInit();
            this.GpbToyManagement.ResumeLayout(false);
            this.GpbToyManagement.PerformLayout();
            this.GpbConnectToys.ResumeLayout(false);
            this.GpbConnectToys.PerformLayout();
            this.GpbToyCommands.ResumeLayout(false);
            this.GpbToyCommands.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnSearchToys;
        private System.Windows.Forms.TextBox TxbLog;
        private System.Windows.Forms.Button BtnStopSearch;
        private System.Windows.Forms.Button BtnConnectToToy;
        private System.Windows.Forms.Button BtnFlash;
        private System.Windows.Forms.Button BtnPowerOff;
        private System.Windows.Forms.Button BtnDisconnectFromToy;
        private System.Windows.Forms.Button BtnGetBattery;
        private System.Windows.Forms.ComboBox CmbToys;
        private System.Windows.Forms.ComboBox CmbCommands;
        private System.Windows.Forms.TrackBar TrbLevel;
        private System.Windows.Forms.Button BtnGo;
        private System.Windows.Forms.PictureBox PbxToy;
        private System.Windows.Forms.ImageList ImlToyIcons;
        private System.Windows.Forms.Button BtnStatus;
        private System.Windows.Forms.Label LblToysFound;
        private System.Windows.Forms.Label LblCommands;
        private System.Windows.Forms.Label LblToysCount;
        private System.Windows.Forms.TextBox TxbToysCount;
        private System.Windows.Forms.GroupBox GpbToyManagement;
        private System.Windows.Forms.GroupBox GpbConnectToys;
        private System.Windows.Forms.GroupBox GpbToyCommands;
        private System.Windows.Forms.Label LblSetLevel;
        private System.Windows.Forms.ProgressBar PgbBatteryLevel;
        private System.Windows.Forms.Label LblBatteryLevel;
        private System.Windows.Forms.TextBox TxbLevel;
    }
}

