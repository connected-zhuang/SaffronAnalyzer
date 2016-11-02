using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Foundation;
using System.Data.Odbc;
using System.Collections;
using System.Threading;
using Saffron;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using System.Runtime;
using Windows.Devices.Enumeration;
using System.Collections.ObjectModel;

namespace SaffronAnalyzer
{
    public enum RunningState {
        Idle,
        Scan,
        Retrieve
    }

    public partial class Form1 : Form
    {
        private BluetoothLEAdvertisementWatcher watcher;
        private RunningState runningState=RunningState.Idle;
        private OdbcConnection conn=new OdbcConnection();
        private string connString = "DSN=MySqlSaffron";
        private SaffronCommandConsole cmdCon = null;
        

        public Form1()
        {
            InitializeComponent();
            this.conn.ConnectionString = this.connString;
            this.watcher = new BluetoothLEAdvertisementWatcher();
        }

        private void startScanningToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void startRetrievingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormSetRetrieving();
            form.Show();
        }

        private void toolStripButtonStartScan_Click(object sender, EventArgs e)
        {
            if (this.runningState != RunningState.Idle) return;

            

            if (!this.CheckIdPrefix()) return;
            this.toolStripTextBoxDevIdPrefix.Enabled = false;
            

            this.listBoxDevices.Items.Clear();
            watcher.Received+=OnAdvertisementReceived;
            this.runningState = RunningState.Scan;
            watcher.Start(); 

        }

        private void OnAdvertisementReceived(BluetoothLEAdvertisementWatcher watcher, BluetoothLEAdvertisementReceivedEventArgs eventArgs)
        {
            string idPrefix = this.toolStripTextBoxDevIdPrefix.Text;

            string id = eventArgs.Advertisement.LocalName;
            if (id.Length!=0 && idPrefix==id.Substring(0,idPrefix.Length) && !this.listBoxDevices.Items.Contains(eventArgs.Advertisement.LocalName))
            {
                if (this.InvokeRequired) {
                    this.Invoke(new MethodInvoker(delegate {
                        this.listBoxDevices.Items.Add(eventArgs.Advertisement.LocalName);
                    }));
                }
            }
                
        }

        private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
            if (this.runningState == RunningState.Scan)
            {
                this.watcher.Received -= OnAdvertisementReceived;
                this.watcher.Stop();

                this.toolStripTextBoxDevIdPrefix.Enabled = true;

                
                this.listBoxDevices.Items.Clear();
            }
            else if (this.runningState == RunningState.Retrieve)
            {
                
                this.toolStripTextBoxDevIdPrefix.Enabled = false;
                this.toolStripTextBoxFromOpenTick.Enabled = false;
                this.toolStripTextBoxSessionName.Enabled = false;
            }

            this.runningState = RunningState.Idle;
        }

        private void toolStripButtonStartRetrieve_Click(object sender, EventArgs e)
        {
            if (this.runningState != RunningState.Idle) return;

            if (!this.CheckIdPrefix()) return;
            if (!this.CheckOpenTick()) return;
            if (!this.CheckSessionName()) return;
            this.toolStripTextBoxDevIdPrefix.Enabled = false;
            this.toolStripTextBoxFromOpenTick.Enabled = false;
            this.toolStripTextBoxSessionName.Enabled = false;

            this.runningState = RunningState.Retrieve;
            
            RetrieveDataFromDevices();
        }

        private void RetrieveDataFromDevices()
        {
            this.listBoxDevices.Items.Clear();
            
            this.textBoxLog.Text = "Start retrieve data from detected devices\r\n";
            watcher.Received += OnAdvertisementReceivedRetrieve;
            watcher.Start();
        }

        private void OnAdvertisementReceivedRetrieve(BluetoothLEAdvertisementWatcher watcher, BluetoothLEAdvertisementReceivedEventArgs eventArgs)
        {
            return;
            string idPrefix = this.toolStripTextBoxDevIdPrefix.Text;
            string id = eventArgs.Advertisement.LocalName;
            if (id.Length != 0 && idPrefix == id.Substring(0, idPrefix.Length) && !this.listBoxDevices.Items.Contains(eventArgs.Advertisement.LocalName))
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(this.RetrieveDataFromDevice),eventArgs);
                if (this.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(delegate {
                        this.listBoxDevices.Items.Add(id);
                        this.textBoxLog.AppendText(String.Format("Device '{0}' is detected and the retrieving task is put on queue.\r\n", id));
                        this.textBoxLog.AppendText("Service UUIDs:\r\n");
                        foreach (Guid guid in eventArgs.Advertisement.ServiceUuids)
                        {
                            this.textBoxLog.AppendText(guid.ToString()+"\r\n");
                        }
                    }));
                    
                }
            }

        }

        private async void RetrieveDataFromDevice(object info)
        {
            BluetoothLEAdvertisementReceivedEventArgs eventArgs = (BluetoothLEAdvertisementReceivedEventArgs)info;
            BluetoothLEDevice device = await BluetoothLEDevice.FromBluetoothAddressAsync(eventArgs.BluetoothAddress);
            DevicePairingResult result;
            //do
            //{
                
                result = await device.DeviceInformation.Pairing.PairAsync(DevicePairingProtectionLevel.None);
            //} while (result.Status != DevicePairingResultStatus.Paired);

            
            foreach (GattDeviceService gattService in device.GattServices)
            {
                foreach (GattCharacteristic characteristic in gattService.GetAllCharacteristics())
                {
                    string uuid = characteristic.Uuid.ToString();
                    
                }
            }



            return;
            //this.cmdCon = new SaffronCommandConsole(adv.LocalName);
            
            this.cmdCon.OnLog += this.OnConsoleLog;
            this.cmdCon.OnCommandEnd += this.OnCommandEnd;
            this.cmdCon.Open();
            this.cmdCon.ExecuteCommand("Records$");
        }

        private void OnConsoleLog(SaffronCommandConsole console, string log)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate {
                    this.textBoxLog.AppendText(log);
                }));
            }
        }

        private void OnCommandEnd(SaffronCommandConsole console, string cmd)
        {
            console.Close();
        }

        

        private bool CheckSessionName()
        {
            string sessionName = this.toolStripTextBoxSessionName.Text;
            if (sessionName.Length == 0)
            {
                MessageBox.Show("The SessionName cannot be empty");
                this.toolStripTextBoxSessionName.Focus();
                return false;
            }
            else
            {
                try
                {
                    this.conn.Open();
                    OdbcCommand cmd = this.conn.CreateCommand();
                    cmd.CommandText = String.Format("Select count(0) From rawdata Where session_name='{0}'", sessionName);
                    int result= Convert.ToInt32(cmd.ExecuteScalar());

                    if (result > 0)
                    {
                        MessageBox.Show(String.Format("The Session Name : '{0}' already exists. Try another name.", sessionName));
                        this.toolStripTextBoxSessionName.Focus();
                        return false;
                    }
                }
                catch (Exception excp)
                {
                    MessageBox.Show("Error: " + excp.Message);
                    return false;
                }
                finally {
                    this.conn.Close();
                }
            }
            
            
            return true;
        }

        private bool CheckOpenTick()
        {
            string sOpenTick = this.toolStripTextBoxFromOpenTick.Text;
            int openTick;
            if (sOpenTick.Length == 0 || !int.TryParse(sOpenTick,out openTick))
            {
                MessageBox.Show("The OpenTick for retrieving must be a number");
                this.toolStripTextBoxFromOpenTick.Focus();
                return false;
            }
            return true;
        }

        private bool CheckIdPrefix()
        {
            string idPrefix = this.toolStripTextBoxDevIdPrefix.Text;
            if (idPrefix.Length == 0)
            {
                MessageBox.Show("The BLE device prefix field cannot be empty");
                this.toolStripTextBoxDevIdPrefix.Focus();
                return false;
            }
            return true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.runningState != RunningState.Idle)
            {
                this.watcher.Stop();
            }
        }

        private void loadDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLoadFromFile form = new FormLoadFromFile();
            form.ShowDialog();
        }

        private void analyzeDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAnalyze form = new FormAnalyze();
            form.ShowDialog();
        }
    }
}
