﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LjData.Models
{
    public partial class Popart
    {
        [JsonProperty(propertyName:"salesOrderCommandId")]
        public string PonbPp { get; set; }

        [JsonProperty(propertyName: "salesOrderCommandOrder")]
        public string OrdrPp { get; set; }

        [JsonProperty(propertyName:"cargoId")]
        public string PartPp { get; set; }

        [JsonProperty(propertyName:"cargoName")]
        public string DescPp { get; set; }

        public string Desc3Pp { get; set; }
        public string SpecPp { get; set; }

        [JsonProperty(propertyName:"cargoQuantity")]
        public decimal? TqtyPp { get; set; }

        public decimal? RecqPp { get; set; }

        [JsonProperty(propertyName:"cargoUnit")]
        public string UnitPp { get; set; }

        [JsonProperty(propertyName:"cargoUnitPrice")]
        public decimal? PricPp { get; set; }

        public string PtypPp { get; set; }
        public decimal? EquivPp { get; set; }
        public decimal? SumPp { get; set; }

        [JsonProperty("scheduleCargoDate")]
        public DateTime? SchdPp { get; set; }

        public string RemkPp { get; set; }
        public DateTime? LdatPp { get; set; }
        
        public string LedtPp { get; set; }// CommandCargoCreator
        public string PlntPp { get; set; }
    }
}
