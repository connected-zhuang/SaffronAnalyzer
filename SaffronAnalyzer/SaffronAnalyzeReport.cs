using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SaffronAnalyzer
{
    public class SaffronAnalyzeReport:IComparable
    {
        public int xScale = 1;
        public int yScale = 1;
        public float radius = 0F;
        public PointF center;
        public int countValidPoints;
        public int countInvalidPoints;
        public Dictionary<PointF, int> includedPoints = new Dictionary<PointF, int>();

        public override string ToString()
        {
            return String.Format("Center: {0}\r\nRadius:{1}\r\nValid Points:{2}\r\nInvalid Points:{3}\r\nPercentage:{4}\r\nY Scale: {5}",
                this.center,this.radius,this.countValidPoints,this.countInvalidPoints,this.Percentage,
                this.yScale);
        }

        public int CompareTo(object obj)
        {
            SaffronAnalyzeReport r = obj as SaffronAnalyzeReport;
            if (r == null) return -1;
            if (this.Percentage!=r.Percentage) return this.Percentage.CompareTo(r.Percentage);
            if (this.radius != r.radius) return (this.radius.CompareTo(this.radius));
            if (this.yScale != r.yScale) return (this.yScale.CompareTo(r.yScale));
            return (this.xScale.CompareTo(r.xScale));
        }

        

        

        public int Percentage {
            get {
                return (int)(this.countValidPoints * 100 / (this.countInvalidPoints + this.countInvalidPoints));
            }
        }
    }
}
