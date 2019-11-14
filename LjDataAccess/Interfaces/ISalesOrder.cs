using System;
using System.Collections.Generic;
using System.Text;
using LjData.Models;

namespace LjDataAccess.Interfaces
{
    public  interface ISalesOrderRepository
    {
        List<dynamic> GetSalesOrderByUserId(string userId);

        List<Pomst> GetSalesOrderListByOrderId(string orderId);
    }
}
