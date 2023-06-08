using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataBase.Tables
{
    public class EventLog
    {
        public int EventId { get; set; }
        public DateTime EventTime { get; set; }
        public int DetectorId { get; set; }
        public int ChanelId { get; set; }
        public double Temperature { get; set; }
        public string EventZone { get; set; }
    }
}
