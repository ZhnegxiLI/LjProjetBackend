using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        [JsonProperty(propertyName: "cargoNameOfiice")]
        public string Desc3Pp { get; set; }

        [JsonProperty(propertyName: "cargoAdresseProduct")]
        public string SpecPp { get; set; }

        [JsonProperty(propertyName:"cargoQuantity")]
        public decimal? TqtyPp { get; set; }

        public decimal? RecqPp { get; set; }

        [JsonProperty(propertyName:"cargoUnit")]
        public string UnitPp { get; set; }

        [JsonProperty(propertyName:"cargoUnitPrice")]
        public decimal? PricPp { get; set; }

        [JsonProperty(propertyName: "unitPriceType")]
        public string PtypPp { get; set; }

        
        public decimal? EquivPp { get; set; }

        [JsonProperty(propertyName: "totalPrice")]
        public decimal? SumPp { get; set; }// Total price
       
        [JsonProperty("scheduleCargoDate")]
        public DateTime? SchdPp { get; set; }

        [JsonProperty("CargoDescripe")]
        public string RemkPp { get; set; }
        public DateTime? LdatPp { get; set; }
        
        public string LedtPp { get; set; }// CommandCargoCreator
        public string PlntPp { get; set; }
    }
}
