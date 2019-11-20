using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LjDataAccess.Interfaces;
using LjData.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace LjWebApplication.Controllers
{
    [Route("api/[controller]/{action}/{id?}")]
    //[ApiController]
    public class SalesOrderController : Controller
    {
        private readonly ISalesOrderRepository _saleOrderRepository;

        public SalesOrderController(ISalesOrderRepository salesOrderRepository)
        {
            _saleOrderRepository = salesOrderRepository;
        }
        // GET: SalesOrder
        [HttpGet]
        public JsonResult GetSalesOrderByUserId(string userId)
        {
            var result = _saleOrderRepository.GetSalesOrderByUserId(userId);
            return Json(result);
        }
        [HttpGet]
        public JsonResult GetSalesOrderByOrderId(string orderId)
        {
            var result = _saleOrderRepository.GetSalesOrderListByOrderId(orderId);
            //string output = JsonConvert.SerializeObject(result);
            return Json(result);
        }

        [HttpPost]
        public JsonResult InsertSalesOrderByOrderId()
        {
            var result = string.Empty;
            using (var reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            InsertOrderParam resultJson = JsonConvert.DeserializeObject<InsertOrderParam>(result);
            int status = _saleOrderRepository.InsertSalesOrderByOrderId(resultJson.orderInfo, resultJson.products);
            var ret = new
            {
                status,
                message = "OK"
            };
            return Json(ret);
        }
    }
}