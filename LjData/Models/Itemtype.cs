using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LjData.Models
{
    /// <summary>
    /// Commodity Type table (Reference)
    /// </summary>
    public partial class Itemtype
    {
        [JsonProperty(PropertyName = "CommodityTypeCode")]
        public string CmpnPty { get; set; }
        [JsonProperty(PropertyName = "CommodityTypeLabel")]
        public string DescPty { get; set; }
        public DateTime? LdatPty { get; set; }
        public string LedtPty { get; set; }
    }
}
