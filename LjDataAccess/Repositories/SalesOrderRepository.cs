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

        public void InsertSalesOrderByOrderId(dynamic orderInfo)
        {
            var order = orderInfo.salesOrderDetail;
            string orderId = orderInfo.PonbPo;
            var products = orderInfo.cargo;

            var oldOrder = context.Pomst.Where(p => p.PonbPo == orderId).FirstOrDefault();
            if (oldOrder != null)
            {
                oldOrder.DatePo = order.date;
                oldOrder.TnamPo = order.receiver;
                oldOrder.TcpyPo = order.departmentLabel;
                oldOrder.TfaxPo = order.receiverFax;
                oldOrder.TtelPo = order.receiverTelephoneNumber;
                oldOrder.FnamPo = order.sender;
                oldOrder.FtelPo = order.senderTelephoneNumber;
                oldOrder.FfaxPo = order.senderFax;
                oldOrder.Rmk1Po = order.Remark1;
                oldOrder.RvmkPo = order.remarkfeedback;
                oldOrder.CstmPo = order.departmentId;
                oldOrder.CreaPo = order.commandCreator;
                oldOrder.FqryjPo = order.messageForAuditor;
                oldOrder.StatPo = order.status;

                var state = context.Pomst.Update(oldOrder).State;

                foreach (var product in products)
                {
                    string cargoId = product.cargoId;
                    var productOld = context.Popart.Where(p => p.PartPp == cargoId).FirstOrDefault();

                    productOld.DescPp = product.cargoName;
                    productOld.TqtyPp = product.cargoQuantity;
                    productOld.UnitPp = product.cargoUnit;
                    productOld.PricPp = product.cargoUnitPrice;
                    productOld.SchdPp = product.scheduleCargoDate;

                    context.Popart.Update(productOld);
                }

            }
            else
            {
                Pomst newOrder = new Pomst
                {
                    DatePo = order.commandeCreateDate,
                    TnamPo = order.receiver,
                    TcpyPo = order.departmentLabel,
                    TfaxPo = order.receiverFax,
                    TtelPo = order.receiverTelephoneNumber,
                    FnamPo = order.sender,
                    FtelPo = order.senderTelephoneNumber,
                    FfaxPo = order.senderFax,
                    Rmk1Po = order.Remark1,
                    RvmkPo = order.remarkfeedback,
                    CstmPo = order.departmentId,
                    CreaPo = order.commandCreator,
                    FqryjPo = order.messageForAuditor,
                    StatPo = order.status,
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

                context.Pomst.Add(orderInfo);

                foreach (var product in products)
                {
                    Popart newCargo = new Popart
                    {
                        DescPp = product.cargoName,
                        TqtyPp = product.cargoQuantity,
                        UnitPp = product.cargoUnit,
                        PricPp = product.cargoUnitPrice,
                        SchdPp = product.scheduleCargoDate
                    };

                    context.Popart.Add(newCargo);

                }
                context.SaveChanges();
            }
        }
    }

}
