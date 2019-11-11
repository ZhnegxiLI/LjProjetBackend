using System;
using System.Collections.Generic;

namespace LjData.Models
{
    public partial class Finished
    {
        public string LocnFns { get; set; }
        public string PartFns { get; set; }
        public decimal? RateFns { get; set; }
        public DateTime? LdatFns { get; set; }
        public string LedtFns { get; set; }
    }
}
