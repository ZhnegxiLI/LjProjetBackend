using System;

namespace LjData.Models
{
    public partial class Settlement
    {
        public string CodeStm { get; set; }
        public bool? SysStm { get; set; }
        public string DescStm { get; set; }
        public DateTime? LdatStm { get; set; }
        public string LedtStm { get; set; }
        public string PlntStm { get; set; }
    }
}
