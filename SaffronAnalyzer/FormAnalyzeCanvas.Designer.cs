namespace SaffronAnalyzer
{
    partial class FormAnalyzeCanvas
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
            this.buttonDrawMiniContainingCircle = new System.Windows.Forms.Button();
            this.buttonDraw100percentCircle = new System.Windows.Forms.Button();
            this.labelCalculatedPrameters = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxCanvas = new System.Windows.Forms.PictureBox();
            this.buttonScaleIncreaseY = new System.Windows.Forms.Button();
            this.buttonScaleDecreaseY = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonScaleIncreaseX = new System.Windows.Forms.Button();
            this.buttonScaleDecreaseX = new System.Windows.Forms.Button();
            this.progressBarRunning = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAutoDetect = new System.Windows.Forms.Button();
            this.textBoxReport = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDrawMiniContainingCircle
            // 
            this.buttonDrawMiniContainingCircle.Location = new System.Drawing.Point(819, 13);
            this.buttonDrawMiniContainingCircle.Name = "buttonDrawMiniContainingCircle";
            this.buttonDrawMiniContainingCircle.Size = new System.Drawing.Size(438, 31);
            this.buttonDrawMiniContainingCircle.TabIndex = 1;
            this.buttonDrawMiniContainingCircle.Text = "Draw min containing circle";
            this.buttonDrawMiniContainingCircle.UseVisualStyleBackColor = true;
            this.buttonDrawMiniContainingCircle.Click += new System.EventHandler(this.buttonDrawMiniContainingCircle_Click);
            // 
            // buttonDraw100percentCircle
            // 
            this.buttonDraw100percentCircle.Location = new System.Drawing.Point(818, 60);
            this.buttonDraw100percentCircle.Name = "buttonDraw100percentCircle";
            this.buttonDraw100percentCircle.Size = new System.Drawing.Size(438, 31);
            this.buttonDraw100percentCircle.TabIndex = 2;
            this.buttonDraw100percentCircle.Text = "Draw max 100% circle";
            this.buttonDraw100percentCircle.UseVisualStyleBackColor = true;
            // 
            // labelCalculatedPrameters
            // 
            this.labelCalculatedPrameters.AutoSize = true;
            this.labelCalculatedPrameters.Location = new System.Drawing.Point(819, 107);
            this.labelCalculatedPrameters.Name = "labelCalculatedPrameters";
            this.labelCalculatedPrameters.Size = new System.Drawing.Size(246, 20);
            this.labelCalculatedPrameters.TabIndex = 3;
            this.labelCalculatedPrameters.Text = "Probability: ?; Center: ?; Radius: ?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(823, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Y Scale";
            // 
            // pictureBoxCanvas
            // 
            this.pictureBoxCanvas.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxCanvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCanvas.Location = new System.Drawing.Point(12, 13);
            this.pictureBoxCanvas.Name = "pictureBoxCanvas";
            this.pictureBoxCanvas.Size = new System.Drawing.Size(768, 768);
            this.pictureBoxCanvas.TabIndex = 8;
            this.pictureBoxCanvas.TabStop = false;
            // 
            // buttonScaleIncreaseY
            // 
            this.buttonScaleIncreaseY.Location = new System.Drawing.Point(915, 148);
            this.buttonScaleIncreaseY.Name = "buttonScaleIncreaseY";
            this.buttonScaleIncreaseY.Size = new System.Drawing.Size(117, 36);
            this.buttonScaleIncreaseY.TabIndex = 9;
            this.buttonScaleIncreaseY.Text = "Increase";
            this.buttonScaleIncreaseY.UseVisualStyleBackColor = true;
            this.buttonScaleIncreaseY.Click += new System.EventHandler(this.buttonScaleIncreaseY_Click);
            // 
            // buttonScaleDecreaseY
            // 
            this.buttonScaleDecreaseY.Location = new System.Drawing.Point(1058, 148);
            this.buttonScaleDecreaseY.Name = "buttonScaleDecreaseY";
            this.buttonScaleDecreaseY.Size = new System.Drawing.Size(117, 36);
            this.buttonScaleDecreaseY.TabIndex = 10;
            this.buttonScaleDecreaseY.Text = "Decrease";
            this.buttonScaleDecreaseY.UseVisualStyleBackColor = true;
            this.buttonScaleDecreaseY.Click += new System.EventHandler(this.buttonScaleDecreaseY_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(823, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "X Scale";
            this.label3.Visible = false;
            // 
            // buttonScaleIncreaseX
            // 
            this.buttonScaleIncreaseX.Enabled = false;
            this.buttonScaleIncreaseX.Location = new System.Drawing.Point(915, 201);
            this.buttonScaleIncreaseX.Name = "buttonScaleIncreaseX";
            this.buttonScaleIncreaseX.Size = new System.Drawing.Size(117, 36);
            this.buttonScaleIncreaseX.TabIndex = 12;
            this.buttonScaleIncreaseX.Text = "Increase";
            this.buttonScaleIncreaseX.UseVisualStyleBackColor = true;
            this.buttonScaleIncreaseX.Visible = false;
            this.buttonScaleIncreaseX.Click += new System.EventHandler(this.buttonScaleIncreaseX_Click);
            // 
            // buttonScaleDecreaseX
            // 
            this.buttonScaleDecreaseX.Enabled = false;
            this.buttonScaleDecreaseX.Location = new System.Drawing.Point(1058, 201);
            this.buttonScaleDecreaseX.Name = "buttonScaleDecreaseX";
            this.buttonScaleDecreaseX.Size = new System.Drawing.Size(117, 36);
            this.buttonScaleDecreaseX.TabIndex = 13;
            this.buttonScaleDecreaseX.Text = "Decrease";
            this.buttonScaleDecreaseX.UseVisualStyleBackColor = true;
            this.buttonScaleDecreaseX.Visible = false;
            this.buttonScaleDecreaseX.Click += new System.EventHandler(this.buttonScaleDecreaseX_Click);
            // 
            // progressBarRunning
            // 
            this.progressBarRunning.Location = new System.Drawing.Point(152, 353);
            this.progressBarRunning.Name = "progressBarRunning";
            this.progressBarRunning.Size = new System.Drawing.Size(485, 39);
            this.progressBarRunning.TabIndex = 14;
            this.progressBarRunning.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBoxReport);
            this.panel1.Controls.Add(this.buttonAutoDetect);
            this.panel1.Location = new System.Drawing.Point(818, 277);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 501);
            this.panel1.TabIndex = 15;
            // 
            // buttonAutoDetect
            // 
            this.buttonAutoDetect.Location = new System.Drawing.Point(156, 452);
            this.buttonAutoDetect.Name = "buttonAutoDetect";
            this.buttonAutoDetect.Size = new System.Drawing.Size(130, 30);
            this.buttonAutoDetect.TabIndex = 0;
            this.buttonAutoDetect.Text = "Auto Detect";
            this.buttonAutoDetect.UseVisualStyleBackColor = true;
            this.buttonAutoDetect.Click += new System.EventHandler(this.buttonAutoDetect_Click);
            // 
            // textBoxReport
            // 
            this.textBoxReport.Location = new System.Drawing.Point(22, 13);
            this.textBoxReport.Multiline = true;
            this.textBoxReport.Name = "textBoxReport";
            this.textBoxReport.ReadOnly = true;
            this.textBoxReport.Size = new System.Drawing.Size(396, 421);
            this.textBoxReport.TabIndex = 1;
            // 
            // FormAnalyzeCanvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 790);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.progressBarRunning);
            this.Controls.Add(this.buttonScaleDecreaseX);
            this.Controls.Add(this.buttonScaleIncreaseX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonScaleDecreaseY);
            this.Controls.Add(this.buttonScaleIncreaseY);
            this.Controls.Add(this.pictureBoxCanvas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCalculatedPrameters);
            this.Controls.Add(this.buttonDraw100percentCircle);
            this.Controls.Add(this.buttonDrawMiniContainingCircle);
            this.Name = "FormAnalyzeCanvas";
            this.Text = "Loading sampling data";
            this.Load += new System.EventHandler(this.FormAnalyzeCanvas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCanvas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDrawMiniContainingCircle;
        private System.Windows.Forms.Button buttonDraw100percentCircle;
        private System.Windows.Forms.Label labelCalculatedPrameters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxCanvas;
        private System.Windows.Forms.Button buttonScaleIncreaseY;
        private System.Windows.Forms.Button buttonScaleDecreaseY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonScaleIncreaseX;
        private System.Windows.Forms.Button buttonScaleDecreaseX;
        private System.Windows.Forms.ProgressBar progressBarRunning;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAutoDetect;
        private System.Windows.Forms.TextBox textBoxReport;
    }
}