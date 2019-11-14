using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace LjData.Models
{
    public partial class Pomst
    {
        [JsonProperty(propertyName:"commandeId")]
        public string PonbPo { get; set; }
        // TODO
        public string TypePo { get; set; }
        [JsonProperty(propertyName: "commandeCreateDate")]
        public DateTime? DatePo { get; set; }
        public DateTime? CrtdPo { get; set; }
        public bool? CmplPo { get; set; }
        [JsonProperty(propertyName:"receiver")]
        public string TnamPo { get; set; }
        public string TcpyPo { get; set; }
        public string TfaxPo { get; set; }
        public string TtelPo { get; set; }
        public string FnamPo { get; set; }
        public string FtelPo { get; set; }
        public string FfaxPo { get; set; }
        public string Rmk1Po { get; set; }
        public string Rmk2Po { get; set; }
        public string Rmk3Po { get; set; }
        public string Rmk4Po { get; set; }
        public string Rmk5Po { get; set; }
        public string Rmk6Po { get; set; }
        public string Rmk7Po { get; set; }
        public DateTime? LdatPo { get; set; }
        public string LedtPo { get; set; }
        public bool? CtovPo { get; set; }
        public bool? SealPo { get; set; }
        public string MrmkPo { get; set; }
        public string RvmkPo { get; set; }
        public string CachetPo { get; set; }
        public string PlntPo { get; set; }
        [JsonProperty(propertyName:"department")]
        public string CstmPo { get; set; }
        public string CreaPo { get; set; }
        public DateTime? ClsdPo { get; set; }
        public short? SmsgPo { get; set; }
        public string SpyjPo { get; set; }
        public string FqrPo { get; set; }
        public string FqryjPo { get; set; }
        public string CwPo { get; set; }
        public string CwyjPo { get; set; }
        public string JlPo { get; set; }
        public string JlyjPo { get; set; }
        [JsonProperty(propertyName:"status")]
        public string StatPo { get; set; }
    }
}
