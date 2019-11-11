using System;
using System.Collections.Generic;

namespace LjData.Models
{
    public partial class Cprice
    {
        public string LocnCp { get; set; }
        public DateTime DateCp { get; set; }
        public string PartCp { get; set; }
        public decimal? IprcCp { get; set; }
        public decimal? OprcCp { get; set; }
        public DateTime? LdatCp { get; set; }
    }
}
