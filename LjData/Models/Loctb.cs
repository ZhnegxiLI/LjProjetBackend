using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LjData.Models
{
    public partial class Loctb
    {
        [JsonProperty(PropertyName = "id")]
        public string LocnLtb { get; set; }
        [JsonProperty(PropertyName = "name")]
        public string DescLtb { get; set; }
        [JsonProperty(PropertyName = "shortLabel")]
        public string SdesLtb { get; set; }
        [JsonProperty(PropertyName = "type")]
        public string TypeLtb { get; set; }
        public string PybmLtb { get; set; }
        public bool? BivnLtb { get; set; }
        public bool? DcckLtb { get; set; }
        public string AddrLtb { get; set; }
        public string PostLtb { get; set; }
        public string TelnLtb { get; set; }
        public string FaxLtb { get; set; }
        public string EmailLtb { get; set; }
        public string WebLtb { get; set; }
        public string CntrLtb { get; set; }
        public string TaxnLtb { get; set; }
        public string AccnLtb { get; set; }
        public string BankLtb { get; set; }
        public string AcntLtb { get; set; }
        public string AtelLtb { get; set; }
        public string RemkLtb { get; set; }
        public DateTime? LdatLtb { get; set; }
        public string LedtLtb { get; set; }
        public DateTime? LatvLtb { get; set; }
        public DateTime? CrtdLtb { get; set; }
        public string PlntLtb { get; set; }
        public string DzdlbLtb { get; set; }
    }
}
