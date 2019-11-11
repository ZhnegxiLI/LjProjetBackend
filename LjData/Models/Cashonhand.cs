using System;
using System.Collections.Generic;

namespace LjData.Models
{
    public partial class Cashonhand
    {
        public string LocnCsh { get; set; }
        public DateTime DateCsh { get; set; }
        public decimal? SumCsh { get; set; }
        public DateTime? LdatCsh { get; set; }
        public string LedtCsh { get; set; }
    }
}
