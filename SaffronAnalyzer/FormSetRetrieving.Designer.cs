namespace SaffronAnalyzer
{
    partial class FormSetRetrieving
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDevIdPrefix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFromTick = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSessionName = new System.Windows.Forms.TextBox();
            this.buttonStartRetrieving = new System.Windows.Forms.Button();
            this.buttonStopRetrieving = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Device ID Prefix";
            // 
            // textBoxDevIdPrefix
            // 
            this.textBoxDevIdPrefix.Location = new System.Drawing.Point(186, 6);
            this.textBoxDevIdPrefix.Name = "textBoxDevIdPrefix";
            this.textBoxDevIdPrefix.Size = new System.Drawing.Size(100, 26);
            this.textBoxDevIdPrefix.TabIndex = 1;
            this.textBoxDevIdPrefix.Text = "BLE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "From Open Tick";
            // 
            // textBoxFromTick
            // 
            this.textBoxFromTick.Location = new System.Drawing.Point(186, 55);
            this.textBoxFromTick.Name = "textBoxFromTick";
            this.textBoxFromTick.Size = new System.Drawing.Size(100, 26);
            this.textBoxFromTick.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Session Name";
            // 
            // textBoxSessionName
            // 
            this.textBoxSessionName.Location = new System.Drawing.Point(186, 98);
            this.textBoxSessionName.Name = "textBoxSessionName";
            this.textBoxSessionName.Size = new System.Drawing.Size(100, 26);
            this.textBoxSessionName.TabIndex = 5;
            // 
            // buttonStartRetrieving
            // 
            this.buttonStartRetrieving.Location = new System.Drawing.Point(350, 28);
            this.buttonStartRetrieving.Name = "buttonStartRetrieving";
            this.buttonStartRetrieving.Size = new System.Drawing.Size(75, 40);
            this.buttonStartRetrieving.TabIndex = 6;
            this.buttonStartRetrieving.Text = "Start";
            this.buttonStartRetrieving.UseVisualStyleBackColor = true;
            // 
            // buttonStopRetrieving
            // 
            this.buttonStopRetrieving.Location = new System.Drawing.Point(350, 77);
            this.buttonStopRetrieving.Name = "buttonStopRetrieving";
            this.buttonStopRetrieving.Size = new System.Drawing.Size(75, 40);
            this.buttonStopRetrieving.TabIndex = 7;
            this.buttonStopRetrieving.Text = "Stop";
            this.buttonStopRetrieving.UseVisualStyleBackColor = true;
            // 
            // FormSetRetrieving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 163);
            this.Controls.Add(this.buttonStopRetrieving);
            this.Controls.Add(this.buttonStartRetrieving);
            this.Controls.Add(this.textBoxSessionName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFromTick);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDevIdPrefix);
            this.Controls.Add(this.label1);
            this.Name = "FormSetRetrieving";
            this.Text = "Set Up Retrieving";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDevIdPrefix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFromTick;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSessionName;
        private System.Windows.Forms.Button buttonStartRetrieving;
        private System.Windows.Forms.Button buttonStopRetrieving;
    }
}