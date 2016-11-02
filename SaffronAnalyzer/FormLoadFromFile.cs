using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Odbc;

namespace SaffronAnalyzer
{
    public partial class FormLoadFromFile : Form
    {
        private System.ComponentModel.BackgroundWorker backgroundLoadWorker;

        public FormLoadFromFile()
        {
            InitializeComponent();

            this.backgroundLoadWorker = new BackgroundWorker();
            this.backgroundLoadWorker.WorkerReportsProgress = true;
            this.backgroundLoadWorker.WorkerSupportsCancellation = true;
            this.backgroundLoadWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundLoadWorker_DoWork);
            this.backgroundLoadWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundLoadWorker_RunWorkerCompleted);
            this.backgroundLoadWorker.ProgressChanged += new ProgressChangedEventHandler(this.onLoadingProcessChanged);
        }

        private void onLoadingProcessChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBarLoading.Value = e.ProgressPercentage;
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
                    this.progressBarLoading.Value = 100;
                    MessageBox.Show("Loading Completed");
                }
                else {
                    MessageBox.Show("Loading Error: "+ e.Result);
                }
            }
            this.buttonStartLoad.Enabled = true;
        }

        private void backgroundLoadWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            StreamReader reader = null;
            OdbcConnection conn = null;
            OdbcCommand cmd = null;
            try
            {


                reader = new StreamReader(this.textBoxFilePath.Text);
                conn = new OdbcConnection("DSN=MySqlSaffron");
                conn.Open();

                string sessionName = this.textBoxSession.Text;
                cmd = conn.CreateCommand();
                cmd.CommandText = String.Format("Insert Into Sessions (name,date) value ('{0}','{1}')", sessionName, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                cmd.ExecuteNonQuery();

                cmd.CommandText = "Insert Into rawdata (session_name,scanning_device,device_name,time_first_detected,open,time_last_detected,duration,rssi,rssi_variance) Values (?,?,?,?,?,?,?,?,?)";
                cmd.Parameters.Add("session_name", OdbcType.VarChar);
                cmd.Parameters.Add("scanning_device", OdbcType.VarChar);
                cmd.Parameters.Add("device_name", OdbcType.VarChar);
                cmd.Parameters.Add("time_first_detected", OdbcType.DateTime);
                cmd.Parameters.Add("open", OdbcType.Int);
                cmd.Parameters.Add("time_last_detected", OdbcType.DateTime);
                cmd.Parameters.Add("duration", OdbcType.Int);
                cmd.Parameters.Add("rssi", OdbcType.Int);
                cmd.Parameters.Add("rssi_variance", OdbcType.Int);

                long size = new FileInfo(this.textBoxFilePath.Text).Length;
                long lengthRead = 0;
                long UnixEpoch = new DateTime(1970, 1, 1, 0, 0, 0,DateTimeKind.Utc).Ticks;

                bool firstLine = true;
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    lengthRead += line.Length;

                    this.backgroundLoadWorker.ReportProgress((int)(lengthRead * 100L / size));

                    string[] fields = line.Split(',');
                    if (firstLine)
                    {
                        firstLine = false;
                        continue;
                    }

                    cmd.Cancel();
                    cmd.Parameters["session_name"].Value = sessionName;
                    cmd.Parameters["scanning_device"].Value = fields[0].Substring(1, fields[0].Length - 2);
                    cmd.Parameters["device_name"].Value = fields[1].Substring(1, fields[1].Length - 2);
                    cmd.Parameters["time_first_detected"].Value = new DateTime(UnixEpoch + Convert.ToInt64(fields[2].Substring(1, fields[2].Length - 2)) * 10000000L); 
                    cmd.Parameters["open"].Value = Convert.ToUInt32(fields[3].Substring(1, fields[3].Length - 2));
                    cmd.Parameters["time_last_detected"].Value = new DateTime(UnixEpoch + Convert.ToInt64(fields[4].Substring(1, fields[4].Length - 2))*10000000L);
                    cmd.Parameters["duration"].Value = Convert.ToInt32(fields[6].Substring(1, fields[6].Length - 2));
                    cmd.Parameters["rssi"].Value = Convert.ToInt32(fields[7].Substring(1, fields[7].Length - 2));

                    if (fields.Length > 8)
                        cmd.Parameters["rssi_variance"].Value = Convert.ToInt32(fields[8].Substring(1, fields[8].Length - 2));
                    else
                        cmd.Parameters["rssi_variance"].Value = 0;
                    cmd.ExecuteNonQuery();

                }
                e.Result = "OK";
            }
            catch (Exception excpt)
            {
                e.Result = excpt.Message;
            }
            finally
            {
                if (reader != null) reader.Close();
                if (cmd != null) cmd.Cancel();
                if (conn != null) conn.Close();
            }
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            DialogResult dlgResult = dlg.ShowDialog();
            if (dlgResult == DialogResult.OK)
            {
                this.textBoxFilePath.Text = dlg.FileName;
            }
        }

        private void buttonStartLoad_Click(object sender, EventArgs e)
        {
            if (this.textBoxSession.Text.Length == 0)
            {
                MessageBox.Show("The Session Name cannot be empty");
                return;
            }
            if (this.textBoxFilePath.Text.Length == 0)
            {
                
                MessageBox.Show("The file path is not set");
                return;
            }
            this.buttonStartLoad.Enabled = false;
            this.backgroundLoadWorker.RunWorkerAsync();

           
            
        }
    }
}
