
using System;

namespace LjData.Models.ViewModel
{
    public class Poviews
    {
        public DateTime? DatePov { get; set; }
        public string DescPov { get; set; }
        //[Column("ORDQ_POV")]
        //public float OrdqPov { get; set; }

        public string UnitPov { get; set; }

        public string CstmPov { get; set; }

        public DateTime? CdatPov { get; set; }

        public string CponPov { get; set; }

        public string VendPov { get; set; }

        public DateTime? VdatPov { get; set; }

        public string VponPov { get; set; }

        public string NamePov { get; set; }

        public string TelnPov { get; set; }

        public string RemkPov { get; set; }

        public bool? CmplPov { get; set; }// Total price
                                          //[Column("IPRC_POV")]
                                          //public float? IprcPov { get; set; }
                                          //[Column("OPRC_POV")]
                                          //public float? OprcPov { get; set; }

        public DateTime? LdatPov { get; set; }

        public string LedtPov { get; set; }// CommandCargoCreator

        public string PlntPov { get; set; }
    }
}
