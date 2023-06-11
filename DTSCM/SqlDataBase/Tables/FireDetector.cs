using System.Collections.Generic;

namespace SqlDataBase.Tables
{
    public class FireDetector
    {
        public List<Channel> Channels = new List<Channel>();
        public int Id { get; set; }
        public string Model { get; set; }
        public int ChannelAmount { get; set; }
        public string MaxChannelLength { get; set; }
    }
}
