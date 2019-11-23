using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using LjData.Models;
using LjDataAccess.Interfaces;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

namespace LjDataAccess.Repositories
{
    public class SalesOrderRepository : ISalesOrderRepository
    {
        private readonly ERPDATA2Context context;
        /// <summary>
        /// Get the status label by code id
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        private string GetStatus(int code)
        {
            switch (code)
            {
                case 0:
                    return "未提交";
                case 1:
                    return "提交到财务";
                case 2:
                    return "财务不同意";
                case 3:
                    return "财务同意";
                case 4:
                    return "经理不同意";
                case 5:
                    return "经理同意";
                case 6:
                    return "已作废";
                case 7:
                    return "冲单";
                default:
                    return "未定义状态";
            }
        }
        public SalesOrderRepository(ERPDATA2Context context)
        {
            this.context = context;
        }

        /// <summary>
        /// Get sales order list by user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<dynamic> GetSalesOrderByUserId(string userId, int? orderStatus)
        {
            try
            {
                var result = context.Pomst.Where(p => p.CreaPo == userId && orderStatus == null || p.StatPo == orderStatus.ToString()).Select(p => new
            {
                commandeId = p.PonbPo,
                commandeCreateDate = p.DatePo,
                receiver = p.TnamPo,
                status = GetStatus(Int32.Parse(p.StatPo)),
                type = p.TypePo
            }).ToList<dynamic>();
            return result;
            }
            catch (Exception e)
            {
                throw e;
            }
      
        }
        /// <summary>
        ///  Get the detail information about a order and its cargo detail
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public dynamic GetSalesOrderListByOrderId(string orderId)
        {
            var result = context.Pomst.Where(p => p.PonbPo == orderId).ToList();
            var newResult = from r in result
                            select (new
                            {
                                salesOrderDetail = r, ///TODO ; 没有回传statusCode
                                cargo = (from po in context.Popart
                                         where po.PonbPp == r.PonbPo
                                         select po).ToList()
                            });
            var r2 = newResult.FirstOrDefault();
            return r2;
        }

        /// <summary>
        ///  Insert or Update the sals order
        /// </summary>
        /// <param name="orderInfo"></param>
        /// /// <param name="products"></param>
        /// <returns></returns>
        public int InsertSalesOrderByOrderId(OrderParam orderInfo, List<ProductParam> products)
        {

            string orderId = orderInfo.title;

            var oldOrder = context.Pomst.Where(p => p.PonbPo == orderId).FirstOrDefault();
            try
            {
                if (oldOrder != null)
                {
                    oldOrder.DatePo = orderInfo.date;
                    oldOrder.TnamPo = orderInfo.receiver;
                    oldOrder.TcpyPo = orderInfo.dept;
                    oldOrder.TfaxPo = orderInfo.faxReceiver;
                    oldOrder.TtelPo = orderInfo.telReceiver;
                    oldOrder.FnamPo = orderInfo.sender;
                    oldOrder.FtelPo = orderInfo.telSender;
                    oldOrder.FfaxPo = orderInfo.faxSender;
                    oldOrder.Rmk1Po = orderInfo.descript;
                    oldOrder.RvmkPo = orderInfo.remarkfeedback;
                    oldOrder.CstmPo = orderInfo.deptId;
                    oldOrder.CreaPo = orderInfo.userId;
                    oldOrder.FqryjPo = orderInfo.messageForAuditor;
                    oldOrder.StatPo = orderInfo.statusCode.ToString();

                    context.Pomst.Update(oldOrder);

                    var productOld = context.Popart.Where(p => p.PonbPp == orderId);

                    foreach (Popart p in productOld)
                    {
                        context.Popart.Remove(p);
                    }

                }
                else
                {

                    orderId = "LJ-" + DateTime.Now.ToString("yyyy") + "-" + context.Popart.Count().ToString("0000");
                    Pomst newOrder = new Pomst
                    {
                        PonbPo = orderId,
                        DatePo = orderInfo.date,
                        TnamPo = orderInfo.receiver,
                        TcpyPo = orderInfo.dept,
                        TfaxPo = orderInfo.faxReceiver,
                        TtelPo = orderInfo.telReceiver,
                        FnamPo = orderInfo.sender,
                        FtelPo = orderInfo.telSender,
                        FfaxPo = orderInfo.faxSender,
                        Rmk1Po = orderInfo.descript,
                        RvmkPo = orderInfo.remarkfeedback,
                        CstmPo = orderInfo.deptId,
                        CreaPo = orderInfo.userId,
                        FqryjPo = orderInfo.messageForAuditor,
                        StatPo = orderInfo.statusCode.ToString(),
                        TypePo = "",
                        LedtPo = "",
                        MrmkPo = "",
                        CachetPo = "",
                        PlntPo = "",
                        SpyjPo = "",
                        FqrPo = "",
                        CwPo = "",
                        CwyjPo = "",
                        JlPo = "",
                        JlyjPo = "",
                        Rmk2Po = "",
                        Rmk3Po = "",
                        Rmk4Po = "",
                        Rmk5Po = "",
                        Rmk6Po = "",
                        Rmk7Po = ""
                    };

                    context.Pomst.Add(newOrder);
                    
                }
                int index = 1;
                foreach (var product in products)
                {
                    
                    {
                        Popart newCargo = new Popart
                        {
                            PonbPp = orderId,
                            OrdrPp = index.ToString("00"),
                            DescPp = product.nameProduct,
                            TqtyPp = product.numberProduct,
                            UnitPp = product.unitProduct,
                            PricPp = product.priceProduct,
                            SchdPp = product.datePayProduct
                        };
                        index++;
                        context.Popart.Add(newCargo);
                    }
                }
                context.SaveChanges();
            }
            catch(Exception e)
            {

                return 1;
            }

            return 0;

            /*productOld.DescPp = product.nameProduct;
            productOld.TqtyPp = product.numberProduct;
            productOld.UnitPp = product.unitProduct;   更新模板是使用
            productOld.PricPp = product.priceProduct; 
            productOld.SchdPp = product.datePayProduct;*/
        }

        public List<dynamic> GetSalesOrderCategoriesByUserId(string userId)
        {
            //var result = context.Pomst.Where(p => p.CreaPo == userId).GroupBy(p => p.StatPo).Select(g=> new
            //{
            //    count = g.Count(),
            //    categoryName = g.
            //}).  ToList<dynamic>();
            var result = from command in context.Pomst
                where command.CreaPo == userId
                group command by command.StatPo
                into g
                select new
                {
                    count = g.Count(),
                    categoryId = g.Key,
                    categoryName = GetStatus(Int32.Parse(g.Key))
                };

            return result.ToList<dynamic>();
        }
    }

}

