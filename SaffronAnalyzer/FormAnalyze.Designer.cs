namespace SaffronAnalyzer
{
    partial class FormAnalyze
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
            this.listBoxSelectedSession = new System.Windows.Forms.ListBox();
            this.treeViewAvailableSession = new System.Windows.Forms.TreeView();
            this.buttonAnalyzeCanvas = new System.Windows.Forms.Button();
            this.listBoxKnowPairs = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonAddDevicePair = new System.Windows.Forms.Button();
            this.buttonRemoveDevicePair = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBoxDevice1 = new System.Windows.Forms.ComboBox();
            this.comboBoxDevice2 = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAddDate = new System.Windows.Forms.Button();
            this.listBoxDates = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxStartingTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEndingTime = new System.Windows.Forms.TextBox();
            this.buttonTimeFrameAdd = new System.Windows.Forms.Button();
            this.listBoxTimeFrames = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSelectedSession
            // 
            this.listBoxSelectedSession.FormattingEnabled = true;
            this.listBoxSelectedSession.ItemHeight = 20;
            this.listBoxSelectedSession.Location = new System.Drawing.Point(359, 39);
            this.listBoxSelectedSession.MultiColumn = true;
            this.listBoxSelectedSession.Name = "listBoxSelectedSession";
            this.listBoxSelectedSession.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxSelectedSession.Size = new System.Drawing.Size(205, 244);
            this.listBoxSelectedSession.TabIndex = 0;
            this.listBoxSelectedSession.DoubleClick += new System.EventHandler(this.buttonRemove_Click);
            // 
            // treeViewAvailableSession
            // 
            this.treeViewAvailableSession.Location = new System.Drawing.Point(24, 39);
            this.treeViewAvailableSession.Name = "treeViewAvailableSession";
            this.treeViewAvailableSession.Size = new System.Drawing.Size(311, 242);
            this.treeViewAvailableSession.TabIndex = 5;
            this.treeViewAvailableSession.DoubleClick += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonAnalyzeCanvas
            // 
            this.buttonAnalyzeCanvas.Location = new System.Drawing.Point(1036, 387);
            this.buttonAnalyzeCanvas.Name = "buttonAnalyzeCanvas";
            this.buttonAnalyzeCanvas.Size = new System.Drawing.Size(82, 32);
            this.buttonAnalyzeCanvas.TabIndex = 6;
            this.buttonAnalyzeCanvas.Text = "Analyze";
            this.buttonAnalyzeCanvas.UseVisualStyleBackColor = true;
            this.buttonAnalyzeCanvas.Click += new System.EventHandler(this.buttonAnalyzeCanvas_Click);
            // 
            // listBoxKnowPairs
            // 
            this.listBoxKnowPairs.FormattingEnabled = true;
            this.listBoxKnowPairs.ItemHeight = 20;
            this.listBoxKnowPairs.Location = new System.Drawing.Point(161, 44);
            this.listBoxKnowPairs.Name = "listBoxKnowPairs";
            this.listBoxKnowPairs.Size = new System.Drawing.Size(308, 244);
            this.listBoxKnowPairs.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(762, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Know Device Pairs";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Device 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Device 2";
            // 
            // buttonAddDevicePair
            // 
            this.buttonAddDevicePair.Location = new System.Drawing.Point(26, 188);
            this.buttonAddDevicePair.Name = "buttonAddDevicePair";
            this.buttonAddDevicePair.Size = new System.Drawing.Size(129, 34);
            this.buttonAddDevicePair.TabIndex = 21;
            this.buttonAddDevicePair.Text = "Add Device Pair";
            this.buttonAddDevicePair.UseVisualStyleBackColor = true;
            this.buttonAddDevicePair.Click += new System.EventHandler(this.buttonAddDevicePair_Click);
            // 
            // buttonRemoveDevicePair
            // 
            this.buttonRemoveDevicePair.Location = new System.Drawing.Point(26, 239);
            this.buttonRemoveDevicePair.Name = "buttonRemoveDevicePair";
            this.buttonRemoveDevicePair.Size = new System.Drawing.Size(129, 34);
            this.buttonRemoveDevicePair.TabIndex = 22;
            this.buttonRemoveDevicePair.Text = "Remove Device Pair";
            this.buttonRemoveDevicePair.UseVisualStyleBackColor = true;
            this.buttonRemoveDevicePair.Click += new System.EventHandler(this.buttonRemoveDevicePair_Click);
            // 
            // comboBoxDevice1
            // 
            this.comboBoxDevice1.FormattingEnabled = true;
            this.comboBoxDevice1.Location = new System.Drawing.Point(26, 72);
            this.comboBoxDevice1.Name = "comboBoxDevice1";
            this.comboBoxDevice1.Size = new System.Drawing.Size(129, 28);
            this.comboBoxDevice1.Sorted = true;
            this.comboBoxDevice1.TabIndex = 23;
            // 
            // comboBoxDevice2
            // 
            this.comboBoxDevice2.FormattingEnabled = true;
            this.comboBoxDevice2.Location = new System.Drawing.Point(26, 140);
            this.comboBoxDevice2.Name = "comboBoxDevice2";
            this.comboBoxDevice2.Size = new System.Drawing.Size(129, 28);
            this.comboBoxDevice2.Sorted = true;
            this.comboBoxDevice2.TabIndex = 24;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(40, 384);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxSelectedSession);
            this.groupBox1.Controls.Add(this.treeViewAvailableSession);
            this.groupBox1.Location = new System.Drawing.Point(16, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(582, 306);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose Session";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAddDate);
            this.groupBox2.Controls.Add(this.listBoxDates);
            this.groupBox2.Location = new System.Drawing.Point(16, 361);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(707, 295);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sampling Dates";
            // 
            // buttonAddDate
            // 
            this.buttonAddDate.Location = new System.Drawing.Point(404, 125);
            this.buttonAddDate.Name = "buttonAddDate";
            this.buttonAddDate.Size = new System.Drawing.Size(75, 32);
            this.buttonAddDate.TabIndex = 1;
            this.buttonAddDate.Text = ">>";
            this.buttonAddDate.UseVisualStyleBackColor = true;
            this.buttonAddDate.Click += new System.EventHandler(this.buttonAddDate_Click);
            // 
            // listBoxDates
            // 
            this.listBoxDates.AllowDrop = true;
            this.listBoxDates.FormattingEnabled = true;
            this.listBoxDates.ItemHeight = 20;
            this.listBoxDates.Location = new System.Drawing.Point(485, 23);
            this.listBoxDates.Name = "listBoxDates";
            this.listBoxDates.Size = new System.Drawing.Size(205, 264);
            this.listBoxDates.TabIndex = 0;
            this.listBoxDates.DoubleClick += new System.EventHandler(this.listBoxDates_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxKnowPairs);
            this.groupBox3.Controls.Add(this.comboBoxDevice1);
            this.groupBox3.Controls.Add(this.buttonRemoveDevicePair);
            this.groupBox3.Controls.Add(this.comboBoxDevice2);
            this.groupBox3.Controls.Add(this.buttonAddDevicePair);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(631, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 317);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Set Know Device Pairs";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxTimeFrames);
            this.groupBox4.Controls.Add(this.buttonTimeFrameAdd);
            this.groupBox4.Controls.Add(this.textBoxEndingTime);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.textBoxStartingTime);
            this.groupBox4.Location = new System.Drawing.Point(733, 361);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(297, 295);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Include Time Frames";
            // 
            // textBoxStartingTime
            // 
            this.textBoxStartingTime.Location = new System.Drawing.Point(83, 29);
            this.textBoxStartingTime.Name = "textBoxStartingTime";
            this.textBoxStartingTime.Size = new System.Drawing.Size(100, 26);
            this.textBoxStartingTime.TabIndex = 0;
            this.textBoxStartingTime.Text = "00:00:00";
            this.textBoxStartingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "End";
            // 
            // textBoxEndingTime
            // 
            this.textBoxEndingTime.Location = new System.Drawing.Point(83, 62);
            this.textBoxEndingTime.Name = "textBoxEndingTime";
            this.textBoxEndingTime.Size = new System.Drawing.Size(100, 26);
            this.textBoxEndingTime.TabIndex = 3;
            this.textBoxEndingTime.Text = "23:59:59";
            this.textBoxEndingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonTimeFrameAdd
            // 
            this.buttonTimeFrameAdd.Location = new System.Drawing.Point(206, 29);
            this.buttonTimeFrameAdd.Name = "buttonTimeFrameAdd";
            this.buttonTimeFrameAdd.Size = new System.Drawing.Size(75, 31);
            this.buttonTimeFrameAdd.TabIndex = 4;
            this.buttonTimeFrameAdd.Text = "Add";
            this.buttonTimeFrameAdd.UseVisualStyleBackColor = true;
            this.buttonTimeFrameAdd.Click += new System.EventHandler(this.buttonAddTimeFrame_Click);
            // 
            // listBoxTimeFrames
            // 
            this.listBoxTimeFrames.FormattingEnabled = true;
            this.listBoxTimeFrames.ItemHeight = 20;
            this.listBoxTimeFrames.Location = new System.Drawing.Point(13, 94);
            this.listBoxTimeFrames.Name = "listBoxTimeFrames";
            this.listBoxTimeFrames.Size = new System.Drawing.Size(268, 184);
            this.listBoxTimeFrames.TabIndex = 5;
            this.listBoxTimeFrames.DoubleClick += new System.EventHandler(this.listBoxTimeFrames_DoubleClick);
            // 
            // FormAnalyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 680);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonAnalyzeCanvas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "FormAnalyze";
            this.Text = "Form Analyze";
            this.Load += new System.EventHandler(this.FormAnalyze_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSelectedSession;
        private System.Windows.Forms.TreeView treeViewAvailableSession;
        private System.Windows.Forms.Button buttonAnalyzeCanvas;
        private System.Windows.Forms.ListBox listBoxKnowPairs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonAddDevicePair;
        private System.Windows.Forms.Button buttonRemoveDevicePair;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBoxDevice1;
        private System.Windows.Forms.ComboBox comboBoxDevice2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox listBoxDates;
        private System.Windows.Forms.Button buttonAddDate;
        private System.Windows.Forms.ListBox listBoxTimeFrames;
        private System.Windows.Forms.Button buttonTimeFrameAdd;
        private System.Windows.Forms.TextBox textBoxEndingTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxStartingTime;
    }
}