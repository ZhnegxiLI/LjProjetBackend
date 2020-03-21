using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LjData.JpushModel;
using LjData.Models;
using LjDataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

namespace LjDataAccess.Repositories
{
    public class SalesOrderRepository : ISalesOrderRepository
    {
        private readonly ERPDATA2Context context;
        private IUtils utils;
        /// <summary>
        /// Get the status label by code id
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        

        public SalesOrderRepository(ERPDATA2Context context)
        {
            this.context = context;
            this.utils = new Utils();
        }

        

        /// <summary>
        /// Get sales order list by user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<dynamic> GetSalesOrderByUserIdAsync(string userId, int? orderStatus, string type, int step, int begin)
        {
            try
            {
            var result = context.Pomst.Where(p => p.CreaPo == userId && p.TypePo == type && (orderStatus == null || p.StatPo == orderStatus.ToString())).Select(p => new
            {
                commandeTypeId = p.TypePo,
                commandeTypeLabel = utils.GetCommandTypeLabelById(p.TypePo),
                commandeId = p.PonbPo,
                commandeCreateDate = p.DatePo,
                updateOn = p.LdatPo.HasValue ? p.LdatPo.Value.ToString("yyyy-MM-dd hh:mm:ss") : "[N/A]",
                updateTime = p.LdatPo,
                receiver = p.TnamPo,
                status = this.utils.GetOrdersStatus(Int32.Parse(p.StatPo)),
                type = p.TcpyPo, // 单位
                creator = context.User.Where(x => x.Id ==userId).Select(y=>y.Name),
                commandeCreator = p.FnamPo //context.Personel.Where(r=>r.EmpnPsl == p.CreaPo).Select(x=>x.NamePsl) 
            }).OrderByDescending(x => x.updateTime);
            var filterResult =new
            {
                data = await result.Skip(begin*step).Take(step).ToListAsync<dynamic>(),
                totalCount = await result.CountAsync()
            };
            return filterResult;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public class CommandStaut
        {
            public string commandeTypeId { get; set; }
            public string statusId { get; set; }
        }
        public async Task<List<dynamic>> GetSalesOrderValidationList(int? categoryId, string type)
        {
            try
            {//TODO: classify by order type and statuts
                var resultGroup = await (from order in context.Pomst
                    where categoryId == null || order.StatPo == categoryId.ToString()
                          && type == "" || order.TypePo == type
                    orderby order.TypePo , order.StatPo, order.DatePo descending
                    group order by new { order.TypePo, order.StatPo } into g
                    select new CommandStaut()
                    {
                        commandeTypeId = g.Key.TypePo,
                        statusId = g.Key.StatPo
                    }).ToListAsync<CommandStaut>();

                var result = (from r in resultGroup
                                select new
                                {
                                    commandDetails =  (from order in context.Pomst
                                        where order.TypePo == r.commandeTypeId && order.StatPo == r.statusId
                                        select new
                                        {
                                            commandeId = order.PonbPo,
                                            commandeCreateDate = order.DatePo,
                                            updateOn = order.LdatPo.HasValue ? order.LdatPo.Value.ToString("yyyy-MM-dd hh:mm:ss") : "[N/A]",
                                            receiver = order.TnamPo,
                                            status = utils.GetOrdersStatus(Int32.Parse(order.StatPo)),
                                            type = order.TcpyPo, // 单位
                                            creator = context.User.Where(x => x.Id == order.CreaPo).Select(y => y.Name).FirstOrDefault( ),
                                            commandeCreator = order.FnamPo //context.Personel.Where(r=>r.EmpnPsl == p.CreaPo).Select(x=>x.NamePsl) 
                                        }),
                                    r.commandeTypeId,
                                    commandTypeLabel = utils.GetCommandTypeLabelById(r.commandeTypeId),
                                    statusLabel = utils.GetOrdersStatus(Int32.Parse(r.statusId)),
                                    r.statusId}).ToList<dynamic>();
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
        public async Task<dynamic> GetSalesOrderListByOrderIdAsync(string orderId)
        {
            var result = await context.Pomst.Where(p => p.PonbPo == orderId).ToListAsync();
            var newResult = (from r in result
                            select (new{
                                commandeType = new
                                {
                                    commandeTypeId = r.TypePo,
                                    commandeTypeLabel = utils.GetCommandTypeLabelById(r.TypePo),
                                },
                                salesOrderDetail = r,
                                cargo = (from po in context.Popart
                                         where po.PonbPp == r.PonbPo
                                         select po) //.ToList()
                            })).ToList();
            var r2 = newResult.FirstOrDefault();
            return r2;
        }

        /// <summary>
        ///  Insert or Update the sals order
        /// </summary>
        /// <param name="orderInfo"></param>
        /// /// <param name="products"></param>
        /// <returns></returns>
        public async Task<int> InsertSalesOrderByOrderIdAsync(OrderParam orderInfo, List<ProductParam> products)
        {
            string orderId = orderInfo.title;
            var oldOrder = await context.Pomst.Where(p => p.PonbPo == orderId).FirstOrDefaultAsync();
            try
            {
                if (oldOrder != null)
                {
                    oldOrder.DatePo = orderInfo.date.Value.Date;
                    oldOrder.TnamPo = orderInfo.receiver;
                    oldOrder.TcpyPo = context.Loctb.Where(p=>p.LocnLtb == orderInfo.deptId).Select(p=>p.DescLtb).FirstOrDefault();
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
                    oldOrder.TypePo = orderInfo.type;
                    oldOrder.CachetPo = orderInfo.seal; //todo
                    oldOrder.CtovPo = orderInfo.copyAfterCheck;
                    oldOrder.MrmkPo = orderInfo.remarkCorrige;
                    oldOrder.RvmkPo = orderInfo.remarkfeedback;
                    oldOrder.LdatPo = DateTime.Now;
                    oldOrder.FcpyPo = orderInfo.entrepriseName;

                    context.Pomst.Update(oldOrder);

                    var productOld = await context.Popart.Where(p => p.PonbPp == orderId).ToListAsync();

                    foreach (Popart p in productOld)
                    {
                        context.Popart.Remove(p);
                    }
                }
                else
                {   
                    var recordCreator = await context.PoCntIssue.Where(p => p.TypePci == "PO").FirstOrDefaultAsync();
                    // TODO
                    // orderId = recordCreator.PrfxPci + DateTime.Now.ToString("yyyy") + "-" + context.Popart.Count().ToString("0000");//recordCreator.MaxnPci++
                    recordCreator.YearPci = DateTime.Now.ToString("yyyy");
                    recordCreator.MaxnPci = recordCreator.MaxnPci+1;
                    context.PoCntIssue.Update(recordCreator);
                    orderId = recordCreator.PrfxPci + recordCreator.YearPci + "-"+ Convert.ToInt32(recordCreator.MaxnPci).ToString("0000");
                    Pomst newOrder = new Pomst
                    {
                        PonbPo = orderId,
                        DatePo = orderInfo.date.Value.Date,
                        LdatPo = DateTime.Now,
                        TnamPo = orderInfo.receiver,
                        TcpyPo = context.Loctb.Where(p => p.LocnLtb == orderInfo.deptId).Select(p => p.DescLtb).FirstOrDefault(),
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
                        TypePo = orderInfo.type,
                        CtovPo = orderInfo.copyAfterCheck,
                        LedtPo = orderInfo.userId,
                        MrmkPo = orderInfo.remarkCorrige,
                        CachetPo = orderInfo.seal,// todo: change to the id 
                        FcpyPo = orderInfo.entrepriseName,
                        SpyjPo = "",
                        FqrPo = "",
                        CwPo = "",
                        CwyjPo = "",
                        JlPo = "",
                        JlyjPo = "",
                        CrtdPo = DateTime.Now,
                        PlntPo = orderInfo.entrepriseType,
                        CmplPo = false
                };
                    context.Pomst.Add(newOrder);
                }
                int index = 1;
                foreach (var product in products)
                {
                        Popart newCargo = new Popart // Take into the cargo repository
                        {
                            PonbPp = orderId,
                            OrdrPp = index.ToString("00"),
                            PartPp = product.idProduct,
                            DescPp = await context.Itemmst.Where(p=>p.PartIt== product.idProduct).Select(p=>p.DescIt).FirstOrDefaultAsync(),//Get from the table data
                            TqtyPp = product.numberProduct,
                            UnitPp = product.unitProduct,
                            PricPp = product.priceProduct,
                            SchdPp = product.datePayProduct,
                            SumPp = product.totalPrice,
                            RemkPp = product.descriptProduct,
                            Desc3Pp = product.nameOffical,
                            PtypPp = product.unitPriceType,
                            SpecPp = product.adresseProduct,
                            PlntPp = product.entrepriseType,
                            LdatPp = DateTime.Now,
                            LedtPp = orderInfo.userId,
                            EquivPp = product.equivalenceValue
                        };
                        index++;
                        context.Popart.Add(newCargo);
                }
               await context.SaveChangesAsync();
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

        public async Task<List<dynamic>> GetSalesOrderCategoriesByUserIdAsync(string userId, string orderType)// 'I'/'0'
        {
            //var result = context.Pomst.Where(p => p.CreaPo == userId).GroupBy(p => p.StatPo).Select(g=> new
            //{
            //    count = g.Count(),
            //    categoryName = g.
            //}).  ToList<dynamic>();
            
            var result = from command in context.Pomst
                where command.CreaPo == userId && command.TypePo == orderType
                         group command by command.StatPo
                into g
                select new
                {
                    count = g.Count(),
                    categoryId = g.Key,
                    categoryName = utils.GetOrdersStatus(Int32.Parse(g.Key))
                };

            return await result.ToListAsync<dynamic>();
        }

        public async Task<dynamic> GetSalesOrderValidationContentAsync(string orderId)
        {
            var result = context.Pomst.Where(p => p.PonbPo == orderId).Select(p=>
                new
                {
                    senderContent = new
                    {
                        senderId = p.FqrPo,
                        senderLabel = "",//todo
                        content= p.FqryjPo
                    },
                    financialContent = new
                    {
                        senderId = p.CwPo,
                        senderLabel = "",//todo
                        content = p.CwyjPo
                    },
                    managerContent = new
                    {
                        senderId = p.JlPo,
                        senderLabel = "",//todo
                        content = p.JlyjPo
                    },
                    actualContent = p.SpyjPo
                }
            );
            return await result.FirstOrDefaultAsync();
        }
        //public int UpdateSalesOrderStatut(string userId,string orderId, string statutCode, string applicationContent, string financialContent,string managerContent)
        //{
        //    try
        //    {
        //        var Order = context.Pomst.Where(p => p.PonbPo == orderId).FirstOrDefault();
        //        if (Order != null)
        //        {
        //            Order.FqrPo = statutCode == "1" ? userId : Order.FqrPo;
        //            Order.CwPo = statutCode == "3" ? userId : Order.CwPo;
        //            Order.JlPo = statutCode == "5" ? userId : Order.JlPo;   
        //            Order.StatPo = statutCode;
        //            Order.SpyjPo = DateTime.Now + "  " + statutCode == "1"?applicationContent: (statutCode=="3"? financialContent :(statutCode == "5"? managerContent:"")) ;
        //            Order.FqryjPo = applicationContent!=null?(DateTime.Now + "  " + applicationContent):null;
        //            Order.CwyjPo = financialContent != null ?(DateTime.Now + "  " + financialContent):null;
        //            Order.JlyjPo = managerContent != null ? (DateTime.Now + "  " + managerContent):null;
        //            context.Pomst.Update(Order);
        //            context.SaveChanges();
        //        }
        //        else
        //        {
        //            return 1;
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        return 1;
        //    }
        //    return 0;
        //}


        public async Task<int> SetSenderApplicationAsync(string userId, string orderId, string statutCode, string applicationContent)
        {
            try
            {
                var Order = await context.Pomst.Where(p => p.PonbPo == orderId).FirstOrDefaultAsync();
                if (Order != null)
                {
                    Order.FqrPo =  userId;
                    Order.StatPo = statutCode;
                    Order.SpyjPo = DateTime.Now + " " + applicationContent;
                    Order.FqryjPo = DateTime.Now + " " + applicationContent;
                    context.Pomst.Update(Order);

                    //MobilePushMessage pushMessgae = new MobilePushMessage
                    //{
                    //    UserGroup = "OrderModule_financialValidation",
                    //    Title = "订单提交 : " + orderId,
                    //    Body = "订单号: " + orderId + ", 变更为: " + utils.GetOrdersStatus(int.Parse("1")),
                    //    IsSend = false
                    //};

                    //context.MobilePushMessage.Add(pushMessgae);
                    await context.SaveChangesAsync();
                }
                else
                {
                    return 1;
                }
                
            }
            catch (Exception e)
            {
                return 1;
            }
            return 0;
        }

        public async Task<int> SetFinancialApplicationAsync(string userId, string orderId, string statutCode, string applicationContent)
        {
            try
            {
                var Order = await context.Pomst.Where(p => p.PonbPo == orderId).FirstOrDefaultAsync();
                if (Order != null)
                {
                    Order.CwPo = userId;
                    Order.StatPo = statutCode;
                    Order.SpyjPo = DateTime.Now + " " + applicationContent;
                    Order.CwyjPo = DateTime.Now + " " + applicationContent;
                    context.Pomst.Update(Order);

                    //MobilePushMessage pushMessgae = new MobilePushMessage
                    //{
                    //    UserId = userId,
                    //    UserGroup = "OrderModule_managerValidation",
                    //    Title = "订单提交 : " + orderId,
                    //    Body = "订单号: " + orderId + ", 变更为: " + utils.GetOrdersStatus(int.Parse("3")),
                    //    IsSend = false
                    //};

                    //context.MobilePushMessage.Add(pushMessgae);
                    await context.SaveChangesAsync();
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception e)
            {
                return 1;
            }
            return 0;
        }

        public async Task<int> SetManagerApplicationAsync(string userId, string orderId, string statutCode, string applicationContent)
        {
            try
            {
                var Order = await context.Pomst.Where(p => p.PonbPo == orderId).FirstOrDefaultAsync();
                if (Order != null)
                {
                    Order.JlPo = userId;
                    Order.StatPo = statutCode;
                    Order.SpyjPo = DateTime.Now + " " + applicationContent;
                    Order.JlyjPo = DateTime.Now + " " + applicationContent;
                    Order.CmplPo = true;
                    context.Pomst.Update(Order);

                    //MobilePushMessage pushMessgae = new MobilePushMessage
                    //{
                    //    UserId = userId,
                    //    Title = "订单提交 : " + orderId,
                    //    Body = "订单号: " + orderId + ", 变更为: " + utils.GetOrdersStatus(int.Parse("5")),
                    //    IsSend = false
                    //};

                    //context.MobilePushMessage.Add(pushMessgae);
                    await context.SaveChangesAsync();

                    var result = context.Database.ExecuteSqlCommand("EXEC Ps_InsertOrUpdate_Poveiw @p0,@p1", orderId, userId);
                    if (result>0)
                    {
                        return 0;
                    }

                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception e)
            {
                return 1;
            }
        }

        public async Task<dynamic> AdvancedSalesOrderSearchAsync(AdvancedSalesOrderSearchParam param)
        {//todo
            var result = (from salesOrder in context.Pomst
                          where (param.fromDate == null || salesOrder.DatePo >= param.fromDate)
                          && (param.toDate == null || salesOrder.DatePo <= param.toDate)
                          && (param.userIds.Count() <= 0 || param.userIds.Contains(salesOrder.CreaPo))
                          && (param.orderTypes.Count() <= 0 || param.orderTypes.Contains(salesOrder.TypePo))
                          && (param.orderStatus.Count() <= 0 || param.orderStatus.Contains(salesOrder.StatPo))
                          && (param.orderId == ""||param.orderId==null ||  EF.Functions.Like(salesOrder.PonbPo, "%"+ param.orderId + "%"))
                          select new
                          {
                              commandeTypeId = salesOrder.TypePo,
                              commandeTypeLabel = utils.GetCommandTypeLabelById(salesOrder.TypePo),
                              commandeId = salesOrder.PonbPo,
                              commandeCreateDate = salesOrder.DatePo,
                              updateOn = salesOrder.LdatPo.ToString(),
                              updateTime = salesOrder.LdatPo,
                              receiver = salesOrder.TnamPo,
                              status = this.utils.GetOrdersStatus(Int32.Parse(salesOrder.StatPo)),
                              type = salesOrder.TcpyPo, // 单位
                              creator = context.User.Where(x => x.Id == salesOrder.CreaPo).Select(y => y.Name),
                              commandeCreator = salesOrder.FnamPo 
                          }).OrderByDescending(p=>p.updateTime);
            var formatedResult = new
            {
                data = await result.Skip(param.begin * param.step).Take(param.step).ToListAsync<dynamic>(),
                totalCount = await result.CountAsync()
            };
            return formatedResult;
        }
    }

}

