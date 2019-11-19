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

        public string GetStatus(int code)
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
            }
            throw new Exception("状态骂错误");
        }
        public SalesOrderRepository(ERPDATA2Context context)
        {
            this.context = context;
        }

        public List<dynamic> GetSalesOrderByUserId(string userId)
        {
            var result = context.Pomst.Where(p => p.CreaPo == userId).Select(p => new
            {
                commandeId = p.PonbPo,
                commandeCreateDate = p.DatePo,
                receiver = p.TnamPo,
                status = p.StatPo,
                type = p.TypePo
            }).ToList<dynamic>();
            return result;
        }

        public dynamic GetSalesOrderListByOrderId(string orderId)
        {
            var result = context.Pomst.Where(p => p.PonbPo == orderId).ToList();
            var newResult = from r in result
                            select (new
                            {
                                salesOrderDetail = r,
                                cargo = (from po in context.Popart
                                         where po.PonbPp == r.PonbPo
                                         select po).ToList()
                            });
            var r2 = newResult.FirstOrDefault();
            return r2;
        }

        public dynamic InsertSalesOrderByOrderId(OrderParam orderInfo, List<ProductParam> products)
        {
            
            string orderId = orderInfo.title;

            var oldOrder = context.Pomst.Where(p => p.PonbPo == orderId).FirstOrDefault();
            try {
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

                    foreach (var product in products)
                    {
                        string cargoId = product.idProduct;
                        var productOld = context.Popart.Where(p => p.PartPp == cargoId).FirstOrDefault();

                        productOld.DescPp = product.nameProduct;
                        productOld.TqtyPp = product.numberProduct;
                        productOld.UnitPp = product.unitProduct;
                        productOld.PricPp = product.priceProduct;
                        productOld.SchdPp = product.datePayProduct;

                        context.Popart.Update(productOld);
                    }

                }
                else
                {
                    Pomst newOrder = new Pomst
                    {
                        PonbPo = orderInfo.title,
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

                    foreach (var product in products)
                    {
                        Popart newCargo = new Popart
                        {
                            DescPp = product.nameProduct,
                            TqtyPp = product.numberProduct,
                            UnitPp = product.unitProduct,
                            PricPp = product.priceProduct,
                            SchdPp = product.datePayProduct
                        };

                        context.Popart.Add(newCargo);

                    }
                    context.SaveChanges();
                }
            }catch(Exception e)
            {
                
                return new{
                            status = 1,
                            msg = e.Message
                          };
            }
            

            return new{   
                        status = 0,
                        msg = "OK"
                       };
        }
    }

}
