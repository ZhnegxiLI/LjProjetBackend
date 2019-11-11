using System;
using System.Collections.Generic;

namespace LjData.Models
{
    public partial class PoCntIssue
    {
        public string TypePci { get; set; }
        public string PrfxPci { get; set; }
        public string YearPci { get; set; }
        public int? MaxnPci { get; set; }
    }
}
