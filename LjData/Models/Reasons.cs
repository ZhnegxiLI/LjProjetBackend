using System;
using System.Collections.Generic;

namespace LjData.Models
{
    public partial class Reasons
    {
        public string TrntRsn { get; set; }
        public string RsncRsn { get; set; }
        public bool? SysRsn { get; set; }
        public string DescRsn { get; set; }
        public string RemkRsn { get; set; }
        public string LedtRsn { get; set; }
        public DateTime? LdatRsn { get; set; }
    }
}
