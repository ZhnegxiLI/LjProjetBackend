using Newtonsoft.Json;
using System;

namespace LjData.Models
{
    /// <summary>
    /// Supplier-Stock
    /// </summary>
    public partial class Ivnloc
    {
        [JsonProperty(PropertyName = "SupplierId")]
        public string LocnIvl { get; set; }
        [JsonProperty(PropertyName = "CommodityId")]
        public string PartIvl { get; set; }
        [JsonProperty(PropertyName = "ProductionId")]
        public string PrdnIvl { get; set; }
        [JsonProperty(PropertyName = "StockQuantity")]
        public decimal? BlceIvl { get; set; }
        public DateTime? LdatIvl { get; set; }
        public string LedtIvl { get; set; }
        public DateTime? InpdIvl { get; set; }
        public string InptIvl { get; set; }
    }
}
