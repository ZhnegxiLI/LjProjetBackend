using System;
using System.Collections.Generic;

namespace LjData.Models
{
    public partial class Cntmtl
    {
        public string CntrMtl { get; set; }
        public string RownMtl { get; set; }
        public string DescMtl { get; set; }
        public string SpecMtl { get; set; }
        public decimal? TqtyMtl { get; set; }
        public string UnitMtl { get; set; }
        public decimal? PricMtl { get; set; }
        public decimal? SumMtl { get; set; }
        public string RemkMtl { get; set; }
        public DateTime? ExpdMtl { get; set; }
        public DateTime? LdatMtl { get; set; }
        public string LedtMtl { get; set; }
        public string OkcolrMtl { get; set; }
        public string PlntMtl { get; set; }
    }
}
