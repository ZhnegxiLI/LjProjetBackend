using System;
using System.Collections.Generic;

namespace LjData.Models
{
    public partial class Trnvend
    {
        public string TypeTrv { get; set; }
        public string DocnTrv { get; set; }
        public string VendTrv { get; set; }
        public string PartTrv { get; set; }
        public decimal? TqtyTrv { get; set; }
        public DateTime? LdatTrv { get; set; }
        public string LedtTrv { get; set; }
    }
}
