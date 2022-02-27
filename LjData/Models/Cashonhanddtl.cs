using System;

namespace LjData.Models
{
    public partial class Cashonhanddtl
    {
        public string CpnyCsd { get; set; }
        public string LocnCsd { get; set; }
        public DateTime DateCsd { get; set; }
        public decimal? SumCsd { get; set; }
        public DateTime? LdatCsd { get; set; }
        public string LedtCsd { get; set; }
    }
}
