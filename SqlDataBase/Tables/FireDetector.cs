using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataBase.Tables
{
    public class FireDetector
    {
        public List<Channel> Channels = new List<Channel>();
        public int Id { get; set; }
        public string Model { get; set; }
        public int ChannelAmount { get; set; }
        public string MaxChanelLength { get; set; }
    }
}
