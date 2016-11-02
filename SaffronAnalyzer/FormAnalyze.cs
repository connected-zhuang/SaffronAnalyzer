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
    public partial class FormAnalyze : Form
    {
        private OdbcConnection conn = new OdbcConnection("DSN=MySqlSaffron");
        List<DateTime> availableDateList = new List<DateTime>();
        public FormAnalyze()
        {
            InitializeComponent();
        }

        private void FormAnalyze_Load(object sender, EventArgs e)
        {
            OdbcCommand cmd = null;
            OdbcDataReader reader = null;
            DateTime date;
            
            
            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "Select name,date From sessions order by date DESC";
                reader = cmd.ExecuteReader();
                
                DateTime lastDate = DateTime.Now.Date;
                bool first = true;
                TreeNode dateNode = null;

                string sessionName = null;
                while (reader.Read())
                {
                    sessionName = reader.GetString(0);
                    date = reader.GetDate(1).Date;

                    if (first)
                    {
                        first = false;
                        dateNode = this.treeViewAvailableSession.Nodes.Add(date.ToString());
                        lastDate = date;
                    }
                    else if (lastDate != date)
                    {
                        dateNode = this.treeViewAvailableSession.Nodes.Add(date.ToString());
                        lastDate = date;
                    }
                    dateNode.Nodes.Add(sessionName);
                }

                


               
            }
            catch (Exception excpt)
            {
                MessageBox.Show("Database Error:"+excpt.Message);
            }
            finally
            {
                if (reader != null) reader.Close();
                if (cmd != null) cmd.Cancel();
                conn.Close();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (this.treeViewAvailableSession.SelectedNode != null)
            {
                if (!this.listBoxSelectedSession.Items.Contains(this.treeViewAvailableSession.SelectedNode.Text))
                {
                    this.listBoxSelectedSession.Items.Add(this.treeViewAvailableSession.SelectedNode.Text);
                    ResetDevicePairsAndCalendar();
                    
                }
            }
        }

        private void ResetDevicePairsAndCalendar()
        {
            
            OdbcCommand cmd = this.conn.CreateCommand() ;
            OdbcDataReader reader = null;
            DateTime date;

            try
            {
                this.comboBoxDevice1.Items.Clear();
                this.comboBoxDevice2.Items.Clear();
                this.monthCalendar1.BoldedDates = null;

                this.listBoxKnowPairs.Items.Clear();
                this.listBoxDates.Items.Clear();

                if (this.listBoxSelectedSession.Items.Count > 0)
                {
                    if (this.conn.State != ConnectionState.Open)
                        this.conn.Open();
                    string sSessions = "(";
                    foreach (string sSes in this.listBoxSelectedSession.Items)
                    {
                        sSessions += "'" + sSes + "',";
                    }
                    sSessions = sSessions.Substring(0, sSessions.Length - 1) + ")";
                    cmd.CommandText = "Select distinct device_name from rawdata Where session_name in " + sSessions;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string dev = reader.GetString(0);
                        if (!this.comboBoxDevice1.Items.Contains(dev))
                            this.comboBoxDevice1.Items.Add(dev);
                        if (!this.comboBoxDevice2.Items.Contains(dev))
                            this.comboBoxDevice2.Items.Add(dev);
                    }

                    reader.Close();
                    cmd.Cancel();
                    this.availableDateList.Clear();
                    cmd.CommandText = "Select DATE(time_first_detected),Date(time_last_detected) from rawdata Where session_name in " + sSessions;
                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        DateTime start = reader.GetDate(0);
                        DateTime end = reader.GetDate(1);

                        for (DateTime tmpDate = start; tmpDate <= end; tmpDate = tmpDate.AddDays(1))
                        {
                            if (!availableDateList.Contains(tmpDate))
                            {
                                availableDateList.Add(tmpDate);
                            }
                        }
                    }

                    this.monthCalendar1.BoldedDates = availableDateList.ToArray();
                }
                

            }
            catch (Exception excpt)
            {
                MessageBox.Show("Database Error:" + excpt.Message);
            }
            finally
            {
                if (reader != null) reader.Close();
                if (cmd != null) cmd.Cancel();
                conn.Close();
            }

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            List<string> tmpArr = new List<string>();
            foreach (string session in this.listBoxSelectedSession.SelectedItems) {
                tmpArr.Add(session);
                
            }
            foreach (string session in tmpArr)
            {
                this.listBoxSelectedSession.Items.Remove(session);
            }
            this.ResetDevicePairsAndCalendar();
        }

        private void buttonAddTimeFrame_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime start = Convert.ToDateTime(this.textBoxStartingTime.Text);
                DateTime end = Convert.ToDateTime(this.textBoxEndingTime.Text);

                if (end <= start)
                {
                    MessageBox.Show("Ending Time is before Starting Time. Discontinued");
                }

                this.listBoxTimeFrames.Items.Add(new TimeFrame(start,end));
            }
            catch (Exception excpt)
            {
                MessageBox.Show("Start Time or End Time format incorrect. Discontinued");
            }
        }

        

        

        private void buttonAddDevicePair_Click(object sender, EventArgs e)
        {
            string device1 = comboBoxDevice1.Text.Trim();
            string device2 = comboBoxDevice2.Text.Trim();
            if (device1.Length == 0 || device2.Length == 0)
            {
                MessageBox.Show("Device Name cannot be empty");
                return;
            }
            if (device1 == device2)
            {
                MessageBox.Show("Device Names cannot be same");
                return;
            }
            string devicePair = (String.Compare(device1,device2)<=0)? (device1+"<->" + device2) : (device2 +"<->"+device1);
            this.listBoxKnowPairs.Items.Add(devicePair);
        }

        private void buttonRemoveDevicePair_Click(object sender, EventArgs e)
        {
            this.listBoxKnowPairs.Items.Remove(this.listBoxKnowPairs.SelectedItem);
        }

        private void buttonAnalyzeCanvas_Click(object sender, EventArgs e)
        {
            FormAnalyzeCanvas form = new FormAnalyzeCanvas();

            string[] sessionArray = new string[this.listBoxSelectedSession.Items.Count];
            this.listBoxSelectedSession.Items.CopyTo(sessionArray,0);

            TimeFrame[] timeFrameArray = new TimeFrame[this.listBoxTimeFrames.Items.Count];
            this.listBoxTimeFrames.Items.CopyTo(timeFrameArray, 0);

            string[] dateArray = new string[this.listBoxDates.Items.Count];
            this.listBoxDates.Items.CopyTo(dateArray, 0);

            string[] devicePairArray = new string[this.listBoxKnowPairs.Items.Count];
            this.listBoxKnowPairs.Items.CopyTo(devicePairArray, 0);

            form.AnalyzerParameterCalculation = new SaffronAnalyzerParameterCalculation(
                sessionArray,
                dateArray,
                timeFrameArray,
                devicePairArray,
                "MySqlSaffron");
            form.ShowDialog();
        }

        private void listBoxDates_DoubleClick(object sender, EventArgs e)
        {
            this.listBoxDates.Items.RemoveAt(this.listBoxDates.SelectedIndex);
        }

        

        private void buttonAddDate_Click(object sender, EventArgs e)
        {
            
            for (DateTime date = this.monthCalendar1.SelectionStart; date <= this.monthCalendar1.SelectionEnd; date=date.AddDays(1))
            {
                string sDate = date.ToString("yyyy/MM/dd");
                if (this.availableDateList.Contains(date) && !this.listBoxDates.Items.Contains(sDate))
                    this.listBoxDates.Items.Add(sDate);
            }
            
        }

        private void listBoxTimeFrames_DoubleClick(object sender, EventArgs e)
        {
            this.listBoxTimeFrames.Items.RemoveAt(this.listBoxTimeFrames.SelectedIndex);
        }
    }

    
}
