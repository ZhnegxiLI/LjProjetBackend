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
        public JsonResult GetSalesOrderByUserId(string userId, int? categoryId, string type)
        {
            var data = _saleOrderRepository.GetSalesOrderByUserId(userId, categoryId, type);
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
        public JsonResult GetSalesOrderCategoriesByUserId(string userId, string type)
        {
           var result = new ApiResult()
            {
                Data = _saleOrderRepository.GetSalesOrderCategoriesByUserId(userId,type),
                Msg = "OK",
                Success = true
            };
            return Json(result);
        }

        [HttpGet]
        public JsonResult GetSalesOrderValidationContent(string orderId)
        {
            var result = new ApiResult()
            {
                Data = _saleOrderRepository.GetSalesOrderValidationContent(orderId),
                Msg = "OK",
                Success = true
            };
            return Json(result);
        }


        public class updateCriteria
        {
            public string userId { get; set; }
            public string applicationContent { get; set; }
            public string orderId { get; set; }
            public string statutCode { get; set; }
        }

         
        [HttpPost]
        public JsonResult UpdateSalesOrderStatut([FromBody]updateCriteria criteria)
        {
            int status = _saleOrderRepository.UpdateSalesOrderStatut(criteria.userId, criteria.orderId, criteria.statutCode,criteria.applicationContent);
            var result = status==0? new ApiResult() { Success = true, Msg = "OK", Type = "200" }: new ApiResult() { Success = false, Msg = "服务器内部错误", Type = "500" };
            return Json(result);
        }
    }
}