using System;
using System.Collections.Generic;
using System.Text;
using LjData.Models;

namespace LjDataAccess.Interfaces
{
    public  interface ISalesOrderRepository
    {
        dynamic AdvancedSalesOrderSearch(AdvancedSalesOrderSearchParam param);
        dynamic GetSalesOrderValidationContent(string orderId);
        dynamic GetSalesOrderByUserId(string userId, int? categoryId, string type, int step, int begin);

        int SetSenderApplication(string userId, string orderId, string statutCode, string applicationContent);
        int SetFinancialApplication(string userId, string orderId, string statutCode, string applicationContent);
        int SetManagerApplication(string userId, string orderId, string statutCode, string applicationContent);
        List<dynamic> GetSalesOrderValidationList(int? categoryId, string type);

        dynamic GetSalesOrderListByOrderId(string orderId);

        int InsertSalesOrderByOrderId(OrderParam orderInfo, List<ProductParam> products);

        //int UpdateSalesOrderStatut(string userId, string orderId, string statutCode, string applicationContent, string financialContent, string managerContent);

        List<dynamic> GetSalesOrderCategoriesByUserId(string userId, string type);
    }
}
