﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LjData.Models;

namespace LjDataAccess.Interfaces
{
    public  interface ISalesOrderRepository
    {
        Task<dynamic> AdvancedSalesOrderSearchAsync(AdvancedSalesOrderSearchParam param);
        Task<dynamic> GetSalesOrderValidationContentAsync(string orderId);
        Task<dynamic> GetSalesOrderByUserIdAsync(string userId, int? categoryId, string type, int step, int begin);

        Task<int> SetSenderApplicationAsync(string userId, string orderId, string statutCode, string applicationContent);
        Task<int> SetFinancialApplicationAsync(string userId, string orderId, string statutCode, string applicationContent);
        Task<int> SetManagerApplicationAsync(string userId, string orderId, string statutCode, string applicationContent);
        Task<List<dynamic>> GetSalesOrderValidationList(int? categoryId, string type);

        Task<dynamic> GetSalesOrderListByOrderIdAsync(string orderId);

        Task<int> InsertSalesOrderByOrderIdAsync(OrderParam orderInfo, List<ProductParam> products);

        //int UpdateSalesOrderStatut(string userId, string orderId, string statutCode, string applicationContent, string financialContent, string managerContent);

        Task<List<dynamic>> GetSalesOrderCategoriesByUserIdAsync(string userId, string type);
    }
}
