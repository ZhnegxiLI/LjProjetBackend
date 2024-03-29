﻿using System.Collections.Generic;

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

    public class CommodityStockDetail : CommodityStock
    {
        public string ClientId { get; set; }

        public string ClientName { get; set; }
        public string ClientShortLabel { get; set; }
        public string ClientType { get; set; }
    }

    public class CommodityStockProductDetail
    {
        public string WarehouseId { get; set; }
        public string WarehouseName { get; set; }
        public string ProductionNumber { get; set; }
        public string TypeLabel { get; set; }
        public decimal? Quantity { get; set; }
    }

    public class CommodityStockDto : CommodityStock
    {
        public List<CommodityStockDetail> Details { get; set; }

        public List<CommodityStockProductDetail> ProductionDetail { get; set; }
    }
}
