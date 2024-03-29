﻿using Newtonsoft.Json;
using System;

namespace LjData.Models
{
    /// <summary>
    /// Commodity table (Reference)
    /// </summary>
    public partial class Itemmst
    {
        [JsonProperty(PropertyName = "CommodityId")]
        public string PartIt { get; set; }
        [JsonProperty(PropertyName = "CommodityLabel")]
        public string DescIt { get; set; }
        [JsonProperty(PropertyName = "CommodityUnit")]
        public string UnitIt { get; set; }
        [JsonProperty(PropertyName = "CommodityTypeCode")]
        public string TypeIt { get; set; }
        [JsonProperty(PropertyName = "CommodityType2Code")]
        public string Typ2It { get; set; }

        public string BarcIt { get; set; }
        public string PybmIt { get; set; }
        public string SpecIt { get; set; }
        public string Pn2It { get; set; }
        public string Desc2It { get; set; }
        public decimal? MaxqIt { get; set; }
        public decimal? MinqIt { get; set; }
        public DateTime? LrecIt { get; set; }
        public decimal? LrprcIt { get; set; }
        public decimal? IprcIt { get; set; }
        public DateTime? LshpIt { get; set; }
        public decimal? LsprcIt { get; set; }
        public decimal? Oprc1It { get; set; }
        public decimal? Oprc2It { get; set; }
        public decimal? Oprc3It { get; set; }
        public decimal? Oprc4It { get; set; }
        public decimal? LprcIt { get; set; }
        public decimal? OprcIt { get; set; }
        public DateTime? PdatIt { get; set; }
        public string PedtIt { get; set; }
        public string RemkIt { get; set; }
        public decimal? PqtyIt { get; set; }
        public string PunitIt { get; set; }
        public string MakrIt { get; set; }
        public DateTime? MakdIt { get; set; }
        public string MadeIt { get; set; }
        public string VendIt { get; set; }
        public DateTime? LdatIt { get; set; }
        public string LedtIt { get; set; }
        public decimal? EquivIt { get; set; }
        public bool? BctrlIt { get; set; }
        public bool? IvnjsIt { get; set; }
    }
}
