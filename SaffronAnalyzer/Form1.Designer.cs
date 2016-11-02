namespace SaffronAnalyzer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxDevices = new System.Windows.Forms.ListBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxDevIdPrefix = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxFromOpenTick = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxSessionName = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonStartScan = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStartRetrieve = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonStop = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataToolStripMenuItemLoadData = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzeToolStripMenuItemAnalyzeData = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 64);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBoxDevices);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxLog);
            this.splitContainer1.Size = new System.Drawing.Size(1556, 716);
            this.splitContainer1.SplitterDistance = 518;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBoxDevices
            // 
            this.listBoxDevices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDevices.FormattingEnabled = true;
            this.listBoxDevices.ItemHeight = 20;
            this.listBoxDevices.Location = new System.Drawing.Point(0, 0);
            this.listBoxDevices.Name = "listBoxDevices";
            this.listBoxDevices.Size = new System.Drawing.Size(518, 716);
            this.listBoxDevices.TabIndex = 0;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLog.Location = new System.Drawing.Point(0, 0);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLog.Size = new System.Drawing.Size(1034, 716);
            this.textBoxLog.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripTextBoxDevIdPrefix,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.toolStripTextBoxFromOpenTick,
            this.toolStripSeparator2,
            this.toolStripLabel3,
            this.toolStripTextBoxSessionName,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.toolStripSeparator5,
            this.toolStripButtonStartScan,
            this.toolStripButtonStartRetrieve,
            this.toolStripButtonStop,
            this.toolStripButtonSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1556, 31);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(133, 28);
            this.toolStripLabel1.Text = "Device id prefix";
            // 
            // toolStripTextBoxDevIdPrefix
            // 
            this.toolStripTextBoxDevIdPrefix.Name = "toolStripTextBoxDevIdPrefix";
            this.toolStripTextBoxDevIdPrefix.Size = new System.Drawing.Size(100, 31);
            this.toolStripTextBoxDevIdPrefix.Text = "BLE";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(132, 28);
            this.toolStripLabel2.Text = "From open tick";
            // 
            // toolStripTextBoxFromOpenTick
            // 
            this.toolStripTextBoxFromOpenTick.Name = "toolStripTextBoxFromOpenTick";
            this.toolStripTextBoxFromOpenTick.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripTextBoxFromOpenTick.Size = new System.Drawing.Size(100, 31);
            this.toolStripTextBoxFromOpenTick.Text = "0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(121, 28);
            this.toolStripLabel3.Text = "Session name";
            // 
            // toolStripTextBoxSessionName
            // 
            this.toolStripTextBoxSessionName.Name = "toolStripTextBoxSessionName";
            this.toolStripTextBoxSessionName.Size = new System.Drawing.Size(100, 31);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButtonStartScan
            // 
            this.toolStripButtonStartScan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStartScan.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStartScan.Image")));
            this.toolStripButtonStartScan.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonStartScan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStartScan.Name = "toolStripButtonStartScan";
            this.toolStripButtonStartScan.Size = new System.Drawing.Size(23, 28);
            this.toolStripButtonStartScan.Text = "Start Scan";
            this.toolStripButtonStartScan.Click += new System.EventHandler(this.toolStripButtonStartScan_Click);
            // 
            // toolStripButtonStartRetrieve
            // 
            this.toolStripButtonStartRetrieve.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStartRetrieve.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStartRetrieve.Image")));
            this.toolStripButtonStartRetrieve.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonStartRetrieve.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStartRetrieve.Name = "toolStripButtonStartRetrieve";
            this.toolStripButtonStartRetrieve.Size = new System.Drawing.Size(23, 28);
            this.toolStripButtonStartRetrieve.Text = "Start Retrieve";
            this.toolStripButtonStartRetrieve.Click += new System.EventHandler(this.toolStripButtonStartRetrieve_Click);
            // 
            // toolStripButtonStop
            // 
            this.toolStripButtonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonStop.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonStop.Image")));
            this.toolStripButtonStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonStop.Name = "toolStripButtonStop";
            this.toolStripButtonStop.Size = new System.Drawing.Size(23, 28);
            this.toolStripButtonStop.Text = "Stop";
            this.toolStripButtonStop.Click += new System.EventHandler(this.toolStripButtonStop_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSave.Image")));
            this.toolStripButtonSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(23, 28);
            this.toolStripButtonSave.Text = "toolStripButtonSave";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1556, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem1
            // 
            this.dataToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadDataToolStripMenuItemLoadData,
            this.analyzeToolStripMenuItemAnalyzeData});
            this.dataToolStripMenuItem1.Name = "dataToolStripMenuItem1";
            this.dataToolStripMenuItem1.Size = new System.Drawing.Size(61, 29);
            this.dataToolStripMenuItem1.Text = "Data";
            // 
            // loadDataToolStripMenuItemLoadData
            // 
            this.loadDataToolStripMenuItemLoadData.Name = "loadDataToolStripMenuItemLoadData";
            this.loadDataToolStripMenuItemLoadData.Size = new System.Drawing.Size(211, 30);
            this.loadDataToolStripMenuItemLoadData.Text = "Load Data";
            this.loadDataToolStripMenuItemLoadData.Click += new System.EventHandler(this.loadDataToolStripMenuItem_Click);
            // 
            // analyzeToolStripMenuItemAnalyzeData
            // 
            this.analyzeToolStripMenuItemAnalyzeData.Name = "analyzeToolStripMenuItemAnalyzeData";
            this.analyzeToolStripMenuItemAnalyzeData.Size = new System.Drawing.Size(211, 30);
            this.analyzeToolStripMenuItemAnalyzeData.Text = "Analyze Data";
            this.analyzeToolStripMenuItemAnalyzeData.Click += new System.EventHandler(this.analyzeDataToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 780);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Saffron Analyzer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBoxDevices;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxDevIdPrefix;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxFromOpenTick;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSessionName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButtonStartScan;
        private System.Windows.Forms.ToolStripButton toolStripButtonStartRetrieve;
        private System.Windows.Forms.ToolStripButton toolStripButtonStop;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadDataToolStripMenuItemLoadData;
        private System.Windows.Forms.ToolStripMenuItem analyzeToolStripMenuItemAnalyzeData;
    }
}

