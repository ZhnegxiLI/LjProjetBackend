using System;
using System.Collections.Generic;

namespace LjData.Models
{
    public partial class Cpdtl
    {
        public string DocnCpd { get; set; }
        public string OrdrCpd { get; set; }
        public string DescCpd { get; set; }
        public string UnitCpd { get; set; }
        public decimal? PricCpd { get; set; }
        public string RemkCpd { get; set; }
        public DateTime? LdatCpd { get; set; }
        public string LedtCpd { get; set; }
        public string PlntCpd { get; set; }
    }
}
