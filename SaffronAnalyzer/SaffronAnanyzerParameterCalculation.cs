using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Drawing;
using System.ComponentModel;

namespace SaffronAnalyzer
{
    public class PointEqualityComparer : IEqualityComparer<Point>
    {
        public bool Equals(Point p1, Point p2)
        {
            return (p1 == p2);
        }

        public int GetHashCode(Point p)
        {
            int hCode = p.X ^ p.Y;  
            return hCode.GetHashCode();
        }
    }
    public class SaffronAnalyzerParameterCalculation
    {
        List<string> sessions = new List<string>();
        List<TimeFrame> timeFrames = new List<TimeFrame>();
        List<string> dates=new List<string>();
        List<string> devicePairs = new List<string>();
        PointEqualityComparer pointComparer = new PointEqualityComparer();
        Dictionary<Point, int> pairedPoints = null; 
        Dictionary<Point, int> nonPairedPoints = null; 
        
        string dsn = null;
        OdbcConnection connection;
        BackgroundWorker backgroundWorker = null;

        public IList<string> Sessions { get { return this.sessions; } }
        public IList<TimeFrame> TimeFrames { get { return this.timeFrames; } }
        public string DSN { get { return this.dsn; }}
        public Dictionary<Point,int> PairedPoints {
            get {
                return this.pairedPoints;
            }
        }
        public Dictionary<Point,int> NonPairedPoints {
            get {
                return this.nonPairedPoints;
            }
        }


        public BackgroundWorker BackgroundWorker {
            get {
                return this.backgroundWorker;
            }
            set {
                this.backgroundWorker = value;
            }
        }

        public SaffronAnalyzerParameterCalculation(ICollection<string> _sessions, ICollection<string> _dates, ICollection<TimeFrame> _timeFrames, ICollection<string> _devicePairs,string _dsn)
        {
            this.sessions.AddRange(_sessions);
            this.dates.AddRange(_dates);
            this.timeFrames.AddRange(_timeFrames);
            this.devicePairs.AddRange(_devicePairs);
            this.dsn = _dsn;
            connection = new OdbcConnection("DSN="+this.dsn);
            this.pairedPoints= new Dictionary<Point, int>(this.pointComparer);
            this.nonPairedPoints = new Dictionary<Point, int>(this.pointComparer);

        }

        public void GetPoints()
        {
           
            OdbcCommand cmd= null;
            OdbcDataReader reader = null;
            try
            {
                connection.Open();
                cmd = connection.CreateCommand();
                PointEqualityComparer pointComparer = new PointEqualityComparer();

                int loops = this.timeFrames.Count * this.dates.Count;
                int loop = 0;
                int count = 0;
                foreach (string sDate in this.dates)
                {

                    foreach (TimeFrame timeFrame in this.timeFrames)
                    {
                        string sStart = sDate + " " + timeFrame.Start.ToString("HH:mm:ss");
                        string sEnd = sDate + " " + timeFrame.End.ToString("HH:mm:ss");

                        string sSessions = "(";
                        foreach (string sSes in this.sessions)
                        {
                            sSessions += "'" + sSes + "',";
                        }
                        sSessions = sSessions.Substring(0, sSessions.Length - 1) + ")";


                        loop++;
                        /*cmd.CommandText = String.Format(
                            "Select count(1) from rawdata Where session_name in {0} And time_first_detected>=STR_TO_DATE('{1}','%Y/%m/%d %H:%i:%s') And  time_last_detected<=STR_TO_DATE('{2}','%Y/%m/%d %H:%i:%s')",
                            sSessions,
                            sStart,
                            sEnd
                            );

                        int totalRecords = Convert.ToInt32(cmd.ExecuteScalar());
                        
                        cmd.Cancel();*/
                        
                        cmd.CommandText = String.Format(
                            "Select scanning_device, device_name, rssi,rssi_variance from rawdata Where session_name in {0} And time_first_detected>=STR_TO_DATE('{1}','%Y/%m/%d %H:%i:%s') And time_last_detected<=STR_TO_DATE('{2}','%Y/%m/%d %H:%i:%s')",
                            sSessions,
                            sStart,
                            sEnd
                            );

                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string dev1 = reader.GetString(0);
                            string dev2 = reader.GetString(1);
                            Dictionary<Point, int> set;
                            if (this.devicePairs.Contains(dev1 + "<->" + dev2) || this.devicePairs.Contains(dev1 + "<->" + dev2))
                            {
                                set = this.pairedPoints;
                            }
                            else set = this.nonPairedPoints;

                            Point point = new Point(reader.GetInt32(2), reader.GetInt32(3));
                            if (set.ContainsKey(point))
                                set[point]++;
                            else set.Add(point, 0);

                            count++;
                            if (this.backgroundWorker != null && this.backgroundWorker.WorkerReportsProgress)
                            {
                                //int percent = (count * 100) / (loops * totalRecords);
                                this.backgroundWorker.ReportProgress(
                                    loop*100/loops
                                    );
                            }
                        }
                        reader.Close();
                        cmd.Cancel();
                    }
                }
            }
            finally
            {
                if (reader != null) reader.Close();
                if (cmd != null) cmd.Cancel();
                if (connection != null) connection.Close();
            }
        }

        /*public RectangleF GetMinimalCircleContainingPairedPoints(int xScale, int yScale, out PointF center, out float radius)
        {
           
            List<PointF> points = new List<PointF>();
            foreach (Point point in this.pairedPoints.Keys)
            {
                PointF pointf = new PointF();
                pointf.X = (float)(point.X * xScale);
                pointf.Y = (float)(point.Y * yScale);
                points.Add(pointf);
            }
            
            Geometry.FindMinimalBoundingCircle(points, out center, out radius);
            return new RectangleF(center.X-radius,center.Y-radius,2*radius,2*radius);
        }*/
    }
}
