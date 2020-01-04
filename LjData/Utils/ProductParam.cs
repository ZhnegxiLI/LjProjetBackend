using System;
using System.Collections.Generic;
using System.Text;

namespace LjData.Models
{
    public class ProductParam
    {
        public string entrepriseType { get; set; }
        public string nameProduct { get; set; }
        public decimal numberProduct { get; set; }
        public string unitProduct { get; set; }
        public decimal priceProduct { get; set; }
        public DateTime datePayProduct { get; set; }
        public string idProduct { get; set; }
        public string adresseProduct { get; set; }
        public string nameOffical { get; set; }
        public string hadPaidProduct { get; set; }
        public string descriptProduct { get; set; }
        public string salesOrderCommandOrder { get; set; }
        public string unitPriceType { get; set; }
        public decimal totalPrice { get; set; }
    }
}
