using System;

namespace LjData.Models
{
    public partial class Tc
    {
        public string TypeTc { get; set; }
        public string TccdTc { get; set; }
        public string FromTc { get; set; }
        public string ToTc { get; set; }
        public bool? SysTc { get; set; }
        public string DescTc { get; set; }
        public string RemkTc { get; set; }
        public DateTime? LdatTc { get; set; }
        public string LedtTc { get; set; }
    }
}
