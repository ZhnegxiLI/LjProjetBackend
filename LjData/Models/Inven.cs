using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace LjData.Models
{
    /// <summary>
    /// Commodity Quantity table (Every commodity can have multiple client)
    /// </summary>
    public partial class Inven
    {
        [JsonProperty(PropertyName = "ClientId")]
        public string LocnIvn { get; set; }
        [JsonProperty(PropertyName = "CommodityId")]
        public string PartIvn { get; set; }
        [JsonProperty(PropertyName = "InitialQuantity")]
        public decimal? BivnIvn { get; set; }
        [JsonProperty(PropertyName = "CurrentQuantity")]
        public decimal? BlceIvn { get; set; }
        [JsonProperty(PropertyName = "UnitQuantity")]
        public decimal? PckqIvn { get; set; }

        public decimal? OcpyIvn { get; set; }
        public decimal? InqIvn { get; set; }
        public decimal? OutqIvn { get; set; }
        public decimal? AdjqIvn { get; set; }
        public decimal? ScpqIvn { get; set; }
        public decimal? UseqIvn { get; set; }
     
        public DateTime? LdatIvn { get; set; }
        public decimal? BfadIvn { get; set; }
        public DateTime? AudtIvn { get; set; }
        public decimal? IprcIvn { get; set; }
        public decimal? SblcIvn { get; set; }
        public DateTime? SldtIvn { get; set; }
        public string SledIvn { get; set; }
    }
}
