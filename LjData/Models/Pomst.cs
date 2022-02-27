using Newtonsoft.Json;
using System;

namespace LjData.Models
{
    public partial class Pomst
    {
        [JsonProperty(propertyName: "commandeId")]
        public string PonbPo { get; set; }

        [JsonProperty(propertyName: "commandeType")]
        public string TypePo { get; set; } //订单种类 I表示采购 0 表示销售

        [JsonProperty(propertyName: "commandeCreateDate")]
        public DateTime? DatePo { get; set; }

        public DateTime? CrtdPo { get; set; }//TODO
        public bool? CmplPo { get; set; }

        [JsonProperty(propertyName: "receiver")]
        public string TnamPo { get; set; }

        [JsonProperty(propertyName: "departmentLabel")]
        public string TcpyPo { get; set; }

        [JsonProperty(propertyName: "receiverFax")]
        public string TfaxPo { get; set; }

        [JsonProperty(propertyName: "receiverTelephoneNumber")]
        public string TtelPo { get; set; }

        [JsonProperty(propertyName: "sender")]
        public string FnamPo { get; set; }

        [JsonProperty(propertyName: "senderTelephoneNumber")]
        public string FtelPo { get; set; }

        [JsonProperty(propertyName: "senderFax")]
        public string FfaxPo { get; set; }

        [JsonProperty(propertyName: "Remark1")]
        public string Rmk1Po { get; set; }

        [JsonProperty(propertyName: "Remark2")]
        public string Rmk2Po { get; set; }

        [JsonProperty(propertyName: "Remark3")]
        public string Rmk3Po { get; set; }

        [JsonProperty(propertyName: "Remark4")]
        public string Rmk4Po { get; set; }

        [JsonProperty(propertyName: "Remark5")]
        public string Rmk5Po { get; set; }

        [JsonProperty(propertyName: "Remark6")]
        public string Rmk6Po { get; set; }

        [JsonProperty(propertyName: "Remark7")]
        public string Rmk7Po { get; set; }

        public DateTime? LdatPo { get; set; }
        public string LedtPo { get; set; }
        public bool? CtovPo { get; set; }
        public bool? SealPo { get; set; }//TODO
        public string MrmkPo { get; set; }
        [JsonProperty(propertyName: "remarkfeedback")]
        public string RvmkPo { get; set; }

        public string CachetPo { get; set; }
        public string PlntPo { get; set; }//TODO

        [JsonProperty(propertyName: "departmentId")]
        public string CstmPo { get; set; }

        [JsonProperty(propertyName: "commandCreator")]
        public string CreaPo { get; set; }

        public DateTime? ClsdPo { get; set; }
        public short? SmsgPo { get; set; }
        public string SpyjPo { get; set; }
        public string FqrPo { get; set; }

        [JsonProperty(propertyName: "messageForAuditor")]
        public string FqryjPo { get; set; }

        public string CwPo { get; set; }
        public string CwyjPo { get; set; }
        public string JlPo { get; set; }

        public string JlyjPo { get; set; }

        [JsonProperty(propertyName: "status")]
        public string StatPo { get; set; }
        [JsonProperty(propertyName: "entrepriseName")]
        public string FcpyPo { get; set; }
    }
}
