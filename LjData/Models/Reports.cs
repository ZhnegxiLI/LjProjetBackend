using System;
using System.Collections.Generic;

namespace LjData.Models
{
    public partial class Reports
    {
        public string NameRpt { get; set; }
        public string DescRpt { get; set; }
        public byte[] ReptRpt { get; set; }
        public string TypeRpt { get; set; }
    }
}
