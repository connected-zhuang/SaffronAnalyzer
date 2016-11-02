using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saffron
{
    public class SaffronCommandConsole
    {
        private string deviceId;

        

        public string DeviceId {
            get { return this.deviceId; }
            set { this.deviceId = value; }
        }

        public delegate void OnCommandStartHandler(SaffronCommandConsole sender, string cmd);
        public delegate void OnCommandEndHandler(SaffronCommandConsole sender, string cmd);
        public delegate void OnLogHandler(SaffronCommandConsole sender, string log);

        public event OnCommandStartHandler OnCommandStart;
        public event OnCommandEndHandler OnCommandEnd;
        public event OnLogHandler OnLog;

        public SaffronCommandConsole(string devid)
        {
            this.deviceId = devid;
        }

        public void Open()
        {
            

        }

        public void Close()
        {
        }

        public void ExecuteCommand(string cmd)
        {
            //this.OnDataReceived += this.OnCommandResponseReceived;
            this.Write(cmd);
            
        }

        private void OnCommandResponseReceived(string argc, string[] argv, byte[] data, int size)
        {
            if (argv[0] == "Records")
            {

            }
        }

        private void Write(string cmd)
        {
            throw new NotImplementedException();
        }
    }
}
