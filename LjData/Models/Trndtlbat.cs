using System;
using System.Collections.Generic;

namespace LjData.Models
{
    public partial class Trndtlbat
    {
        public string TypeTdb { get; set; }
        public string DocnTdb { get; set; }
        public string FlocTdb { get; set; }
        public string PartTdb { get; set; }
        public string FtypTdb { get; set; }
        public string FdocTdb { get; set; }
        public int FsnoTdb { get; set; }
        public decimal? QtyTdb { get; set; }
        public decimal? AddqTdb { get; set; }
        public decimal? RejqTdb { get; set; }
        public decimal? IprcTdb { get; set; }
        public decimal? OprcTdb { get; set; }
        public bool? ChckTdb { get; set; }
        public string OrgtTdb { get; set; }
        public string OrgdTdb { get; set; }
    }
}
