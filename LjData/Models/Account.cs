using System;
using System.Collections.Generic;

namespace LjData.Models
{
    public partial class Account
    {
        public string TypeAtn { get; set; }
        public string PlntAtn { get; set; }
        public string AccnAtn { get; set; }
        public bool? SysAtn { get; set; }
        public string DescAtn { get; set; }
        public string Prt2Atn { get; set; }
        public string Prt1Atn { get; set; }
        public decimal? YbegAtn { get; set; }
        public decimal? MbegAtn { get; set; }
        public decimal? BlceAtn { get; set; }
        public string DollAtn { get; set; }
        public decimal? IsumAtn { get; set; }
        public decimal? OsumAtn { get; set; }
        public DateTime? LatvAtn { get; set; }
        public DateTime? LdatAtn { get; set; }
        public string LedtAtn { get; set; }
    }
}
