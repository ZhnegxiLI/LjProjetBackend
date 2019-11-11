using System;
using System.Collections.Generic;

namespace LjData.Models
{
    public partial class Bom
    {
        public string PrntBm { get; set; }
        public string CmpnBm { get; set; }
        public DateTime EffdBm { get; set; }
        public decimal? NumtBm { get; set; }
        public decimal? DenoBm { get; set; }
        public decimal? LossBm { get; set; }
        public DateTime? ClsdBm { get; set; }
        public DateTime? LdatBm { get; set; }
        public string LedtBm { get; set; }
    }
}
