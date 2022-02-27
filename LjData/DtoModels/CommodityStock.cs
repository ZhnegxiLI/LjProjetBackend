using System;
using System.Collections.Generic;
using System.Text;

namespace LjData.DtoModels
{
    public class CommodityStock
    {
        public string CommodityId { get; set; }
        public string CommodityLabel { get; set; }
        public decimal? InitialQuantity { get; set; }
        public decimal? CurrentQuantity { get; set; }
        public decimal? UnitQuantity { get; set; }
        public string Unit { get; set; }
        public string CommodityTypeCode { get; set; }
        public string CommodityTypeLabel { get; set; }
        public string CommodityType2Code { get; set; }
    }

    public class CommodityStockDetail:CommodityStock
    {
        public string ClientId { get; set; }

        public string ClientName { get; set; }
        public string ClientShortLabel { get; set; }
        public string ClientType { get; set; }
    }

    public class CommodityStockDto : CommodityStock
    {
        public List<CommodityStockDetail> Details { get; set; }
    }
}
