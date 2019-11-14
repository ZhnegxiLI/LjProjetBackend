using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LjData.Models;
using LjDataAccess.Interfaces;

namespace LjDataAccess.Repositories
{
    public class SalesOrderRepository : ISalesOrderRepository
    {
        private readonly ERPDATA2Context context;

        public SalesOrderRepository(ERPDATA2Context context)
        {
            this.context = context;
        }
        public List<dynamic> GetSalesOrderByUserId(string userId)
        {
            var result = context.Pomst.Where(p => p.CreaPo == userId).Select(p => new
            {
                commandeId =  p.PonbPo,
                commandeCreateDate = p.DatePo,
                 receiver = p.TnamPo,
                status = p.StatPo,
                type = p.TypePo
            }).ToList<dynamic>();
            return result;
        }

        public List<Pomst> GetSalesOrderListByOrderId(string orderId)
        {
            var result = context.Pomst.Where(p => p.PonbPo == orderId).ToList();
            return result;
        }
    }
}
