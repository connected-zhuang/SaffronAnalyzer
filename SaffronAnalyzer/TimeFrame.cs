using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaffronAnalyzer
{
    public class TimeFrame
    {
        private DateTime start;
        private DateTime end;
        public TimeFrame(DateTime _start, DateTime _end)
        {
            this.start = _start;
            this.end = _end;
        }

        public DateTime Start { get { return this.start; } }
        public DateTime End { get { return this.end; } }

        public override string ToString()
        {
            return start.ToString("HH:mm:ss") + "~" + end.ToString("HH:mm:ss");
        }
    }
}
