using System;
using System.Collections.Generic;
using System.Text;
using LjData.Models;

namespace LjDataAccess.Interfaces
{
    public  interface ISalesOrderRepository
    {
        List<dynamic> GetSalesOrderByUserId(string userId, int? categoryId, string type);

        dynamic GetSalesOrderListByOrderId(string orderId);

        int InsertSalesOrderByOrderId(OrderParam orderInfo, List<ProductParam> products);

        List<dynamic> GetSalesOrderCategoriesByUserId(string userId, string type);
    }
}
