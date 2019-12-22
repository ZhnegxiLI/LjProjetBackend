﻿using System;
using System.Collections.Generic;
using System.Text;
using LjData.Models;

namespace LjDataAccess.Interfaces
{
    public  interface ISalesOrderRepository
    {
        dynamic GetSalesOrderValidationContent(string orderId);
        List<dynamic> GetSalesOrderByUserId(string userId, int? categoryId, string type);

        List<dynamic> GetSalesOrderValidationList(int? categoryId, string type);

        dynamic GetSalesOrderListByOrderId(string orderId);

        int InsertSalesOrderByOrderId(OrderParam orderInfo, List<ProductParam> products);

        int UpdateSalesOrderStatut(string userId, string orderId, string statutCode, string applicationContent, string financialContent, string managerContent);

        List<dynamic> GetSalesOrderCategoriesByUserId(string userId, string type);
    }
}
