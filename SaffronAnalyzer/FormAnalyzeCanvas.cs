using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace SaffronAnalyzer
{
    public partial class FormAnalyzeCanvas : Form
    {
        private SaffronAnalyzerParameterCalculation analyzerParameterCalculation = null;
        private int xScale = 1;
        private int yScale = 1;
        private int scale = 1;
        private Bitmap canvas = null;
        
        private List<SaffronAnalyzeReport> reports = new List<SaffronAnalyzeReport>();

        BackgroundWorker backgroundLoadWorker = null;
        BackgroundWorker backgroundAutoAnalyzeWorker = null;

        public FormAnalyzeCanvas()
        {
            InitializeComponent();

            this.backgroundLoadWorker = new BackgroundWorker();
            this.backgroundLoadWorker.WorkerReportsProgress = true;
            this.backgroundLoadWorker.WorkerSupportsCancellation = true;
            this.backgroundLoadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundLoadWorker_DoWork);
            this.backgroundLoadWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundLoadWorker_RunWorkerCompleted);
            this.backgroundLoadWorker.ProgressChanged += new ProgressChangedEventHandler(this.onProcessChanged);

            this.backgroundAutoAnalyzeWorker = new BackgroundWorker();
            this.backgroundAutoAnalyzeWorker.WorkerReportsProgress = true;
            this.backgroundAutoAnalyzeWorker.WorkerSupportsCancellation = true;
            this.backgroundAutoAnalyzeWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundAutoAnalyzeWorker_DoWork);
            this.backgroundAutoAnalyzeWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundAutoAnalyzeWorker_RunWorkerCompleted);
            this.backgroundLoadWorker.ProgressChanged += new ProgressChangedEventHandler(this.onProcessChanged);

        }

        private void onProcessChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBarRunning.Value = e.ProgressPercentage;
        }

        private void backgroundLoadWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show("Loading Canceled");
            else if (e.Error != null)
                MessageBox.Show("Loading Error: " + e.Error.Message);
            else
            {
                if ((string)e.Result == "OK")
                {
                    this.progressBarRunning.Value = 100;
                    Graphics g=Graphics.FromImage(this.canvas);
                    g.Clear(Color.White);
                    g.Dispose();
                    this.DrawPoints();
                    this.pictureBoxCanvas.Refresh();
                }
                else
                {
                    MessageBox.Show("Loading Error: " + e.Result);
                }
            }
            this.progressBarRunning.Visible = false;
        }

        private void backgroundLoadWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            
            this.pictureBoxCanvas.Image = this.canvas;
            try
            {
                this.analyzerParameterCalculation.BackgroundWorker = this.backgroundLoadWorker;
                this.analyzerParameterCalculation.GetPoints();
                
                e.Result = "OK";
            }
            catch (Exception excpt)
            {
                e.Result = excpt.Message;
            }
            
        }

        public SaffronAnalyzerParameterCalculation AnalyzerParameterCalculation
        {
            get { return this.analyzerParameterCalculation; }
            set { this.analyzerParameterCalculation = value; }
        }

        private void FormAnalyzeCanvas_Load(object sender, EventArgs e)
        {
            this.progressBarRunning.Visible = true;
            this.canvas = new Bitmap(this.pictureBoxCanvas.Size.Width, this.pictureBoxCanvas.Size.Height);
            this.backgroundLoadWorker.RunWorkerAsync();
            

        }

        private void DrawPoints()
        {
            
            this.scale = this.pictureBoxCanvas.Size.Width / 128;
            
            /*Graphics g = Graphics.FromImage(this.canvas);
            g.Clear(this.pictureBoxCanvas.BackColor);*/

            
            //System.Drawing.SolidBrush brush = new System.Drawing.SolidBrush(System.Drawing.Color.FromArgb(128,Color.Red));
            foreach (Point point in this.analyzerParameterCalculation.PairedPoints.Keys)
            {

                int x = point.X * this.xScale;
                int y = point.Y * this.yScale;
                //g.FillEllipse(brush, new Rectangle(x , y , x + this.scale, y + this.scale));
                this.canvas.SetPixel(x*this.scale, y*this.scale,Color.FromArgb(128,Color.Red));
        
            }

            //brush.Color = Color.FromArgb(128,Color.Blue);
            foreach (Point point in this.analyzerParameterCalculation.NonPairedPoints.Keys)
            {
                int x = point.X * this.xScale;
                int y = point.Y * this.yScale;
                //g.FillEllipse(brush, new Rectangle(x, y, x + this.scale, y + this.scale));
                this.canvas.SetPixel(x*this.scale, y*this.scale, Color.FromArgb(128, Color.Blue));
            }
            
        }

        private void buttonScaleIncreaseY_Click(object sender, EventArgs e)
        {
            if (this.yScale < 128)
            {
                this.yScale++;
                Graphics g = Graphics.FromImage(this.canvas);
                g.Clear(Color.White);
                this.DrawPoints();
                
                DrawCircle();
                this.pictureBoxCanvas.Refresh();
            }

            
        }

        private void buttonScaleDecreaseY_Click(object sender, EventArgs e)
        {
            if (this.yScale > 1)
            {
                this.yScale--;
                Graphics g = Graphics.FromImage(this.canvas);
                g.Clear(Color.White);
                this.DrawPoints();
                DrawCircle();
                this.pictureBoxCanvas.Refresh();
            }
        }

        private void buttonScaleIncreaseX_Click(object sender, EventArgs e)
        {
            if (this.xScale < 128)
            {
                this.xScale++;
                Graphics g = Graphics.FromImage(this.canvas);
                g.Clear(Color.White);
                this.DrawPoints();
                DrawCircle();
                this.pictureBoxCanvas.Refresh();
            }
        }

        private void buttonScaleDecreaseX_Click(object sender, EventArgs e)
        {
            if (this.xScale > 1)
            {
                this.xScale--;
                Graphics g = Graphics.FromImage(this.canvas);
                g.Clear(Color.White);
                this.DrawPoints();
                DrawCircle();
                this.pictureBoxCanvas.Refresh();
            }
        }

        private void buttonDrawMiniContainingCircle_Click(object sender, EventArgs e)
        {
            DrawCircle();
            this.pictureBoxCanvas.Refresh();
        }

        private void GetCircle(SaffronAnalyzeReport report)
        {
            PointF center;
            float radius;
            List<PointF> points = new List<PointF>();

            foreach (Point point in this.analyzerParameterCalculation.PairedPoints.Keys)
            {
                points.Add(new PointF((float)point.X * this.xScale, (float)point.Y * this.yScale));

            }
            Geometry.FindMinimalBoundingCircle(points, out center, out radius);
            report.radius = radius;
            report.center = center;
            report.xScale = this.xScale;
            report.yScale = this.yScale;
            report.countInvalidPoints = 0;
            report.countValidPoints = points.Count;
            foreach (Point point in this.analyzerParameterCalculation.NonPairedPoints.Keys)
            {
                if ((point.X * this.xScale - center.X) * (point.X * this.xScale - center.X) + (point.Y * this.yScale - center.Y) * (point.Y * this.yScale - center.Y) <= radius * radius)
                {
                    if (report.includedPoints.ContainsKey(point)) report.includedPoints[point]++;
                    else report.includedPoints.Add(point,1);
                    report.countInvalidPoints += this.analyzerParameterCalculation.NonPairedPoints[point];
                }
            }
            foreach (Point point in this.analyzerParameterCalculation.PairedPoints.Keys)
            {
                if (report.includedPoints.ContainsKey(point)) report.includedPoints[point]+= this.analyzerParameterCalculation.PairedPoints[point];
                else report.includedPoints.Add(point, this.analyzerParameterCalculation.PairedPoints[point]);
                report.countValidPoints += this.analyzerParameterCalculation.PairedPoints[point];
            }

        }

        private void DrawCircle()
        {
            

            SaffronAnalyzeReport report=new SaffronAnalyzeReport();
            GetCircle(report);
            
            this.scale = this.pictureBoxCanvas.Size.Width / 128;
            Graphics g = Graphics.FromImage(this.canvas);

            System.Drawing.Pen pen = new Pen(Color.FromArgb(128, Color.Yellow), 1);
            g.DrawEllipse(pen, new RectangleF((report.center.X - report.radius) * this.scale, 
                (report.center.Y - report.radius) * this.scale, 
                2 * report.radius * this.scale, 2 * report.radius * this.scale));

            g.Dispose();

            
            
            this.labelCalculatedPrameters.Text = String.Format("Probability: {0,6:P2}; Center: ({1},{2}); Radius: {3}",
                report.Percentage,
                report.center.X, report.center.Y, report.radius);
            
        }

        private void buttonAutoDetect_Click(object sender, EventArgs e)
        {

            this.progressBarRunning.Visible = true;
            this.backgroundAutoAnalyzeWorker.RunWorkerAsync();

            

            
        }

        

        private void backgroundAutoAnalyzeWorker_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                SaffronAnalyzeReport report=null;
                this.reports.Clear();
                
                for (this.yScale = 1; this.yScale <= 128; this.yScale++)
                {
                    report = new SaffronAnalyzeReport();
                    GetCircle(report);
                    this.reports.Add(report);
                    this.backgroundAutoAnalyzeWorker.ReportProgress(this.yScale * 100 / 128);
                }

                foreach (SaffronAnalyzeReport r in this.reports)
                {
                    if (report == null || report.CompareTo(r)>0 )
                    {
                        report = r;
                    }
                }

                if (report != null)
                {
                    e.Result = report;
                }

            }
            catch (Exception excpt)
            {
                e.Result = excpt.Message;
            }
        }

        private void backgroundAutoAnalyzeWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
                MessageBox.Show("Loading Canceled");
            else if (e.Error != null)
                MessageBox.Show("Loading Error: " + e.Error.Message);
            else
            {
                SaffronAnalyzeReport report = e.Result as SaffronAnalyzeReport;
                if (report!=null)
                {
                    

                    this.scale = this.pictureBoxCanvas.Size.Width / 128;
                    Graphics g = Graphics.FromImage(this.canvas);
                    g.Clear(Color.White);
                    
                    DrawPoints();

                    System.Drawing.Pen pen = new Pen(Color.FromArgb(128, Color.Yellow), 1);
                    g.DrawEllipse(pen, new RectangleF((report.center.X - report.radius) * this.scale,
                        (report.center.Y - report.radius) * this.scale,
                        2 * report.radius * this.scale, 2 * report.radius * this.scale));

                    g.Dispose();
                    this.pictureBoxCanvas.Refresh();

                    this.labelCalculatedPrameters.Text = String.Format("Property: {0,6:P2}; Center: ({1},{2}); Radius: {3}",
                        report.Percentage,
                        report.center.X, report.center.Y, report.radius);

                    this.textBoxReport.Text = report.ToString();
                }
                else
                {
                    MessageBox.Show("Loading Error: " + (string)e.Result);
                }
            }
            this.progressBarRunning.Visible = false;
        }
    }
}
