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
using LjWebApplication.Model;
using Microsoft.AspNetCore.Authorization;

namespace LjWebApplication.Controllers
{
    [Route("api/[controller]/{action}/{id?}")]
    //[ApiController]
    [Authorize]
    public class SalesOrderController : Controller
    {
        private readonly ISalesOrderRepository _saleOrderRepository;

        public SalesOrderController(ISalesOrderRepository salesOrderRepository)
        {
            _saleOrderRepository = salesOrderRepository;
        }
        // GET: SalesOrder
        [HttpGet]
        public JsonResult GetSalesOrderByUserId(string userId, int? categoryId)
        {
            var data = _saleOrderRepository.GetSalesOrderByUserId(userId, categoryId);
            ApiResult result = new ApiResult() { Success = true, Msg = "OK", Type = "200", Data = data };
            return Json(result);
        }
        [HttpGet]
        public JsonResult GetSalesOrderByOrderId(string orderId)
        {
            var data = _saleOrderRepository.GetSalesOrderListByOrderId(orderId);
            //string output = JsonConvert.SerializeObject(result);
            ApiResult result = new ApiResult() { Success = true, Msg = "OK", Type = "200", Data=data };
            return Json(result);
        }

        [HttpPost]
        public JsonResult InsertSalesOrderByOrderId()
        {
            var result = string.Empty;
            ApiResult ret;
            using (var reader = new StreamReader(Request.Body, Encoding.UTF8))
            {
                result = reader.ReadToEnd();
            }
            InsertOrderParam resultJson = JsonConvert.DeserializeObject<InsertOrderParam>(result);
            int status = _saleOrderRepository.InsertSalesOrderByOrderId(resultJson.orderInfo, resultJson.products);
            if (status == 0) {
                ret = new ApiResult() { Success = true, Msg = "OK", Type = "200" };
            }
            else
            {
                ret = new ApiResult() { Success = false, Msg = "服务器内部错误", Type = "500" };
            }
            return Json(ret);
        }

        [HttpGet]
        public JsonResult GetSalesOrderCategoriesByUserId(string userId)
        {
           var result = new ApiResult()
            {
                Data = _saleOrderRepository.GetSalesOrderCategoriesByUserId(userId),
                Msg = "OK",
                Success = true
            };
            return Json(result);
        }
    }
}