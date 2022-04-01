using LjData.Models;
using LjDataAccess.Interfaces;
using LjWebApplication.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        public async Task<JsonResult> GetSalesOrderByUserId(string userId, int? categoryId, string type, int step, int begin)
        {
            var data = await _saleOrderRepository.GetSalesOrderByUserIdAsync(userId, categoryId, type, step, begin);
            ApiResult result = new ApiResult() { Success = true, Msg = "OK", Type = "200", Data = data };
            return Json(result);
        }

        [HttpPost]
        public async Task<JsonResult> GetSalesOrderValidationList(int? categoryId, string type)
        {
            var data = await _saleOrderRepository.GetSalesOrderValidationList(categoryId, type);
            ApiResult result = new ApiResult() { Success = true, Msg = "OK", Type = "200", Data = data };
            return Json(result);
        }

        [HttpGet]
        public async Task<JsonResult> GetSalesOrderByOrderId(string orderId)
        {
            var data = await _saleOrderRepository.GetSalesOrderListByOrderIdAsync(orderId);
            //string output = JsonConvert.SerializeObject(result);
            ApiResult result = new ApiResult() { Success = true, Msg = "OK", Type = "200", Data = data };
            return Json(result);
        }

        [HttpPost]
        public async Task<JsonResult> InsertSalesOrderByOrderId([FromBody] InsertOrderParam criteria)
        {
            ApiResult ret;
            int status = await _saleOrderRepository.InsertSalesOrderByOrderIdAsync(criteria.orderInfo, criteria.products);
            if (status == 0)
            {
                ret = new ApiResult() { Success = true, Msg = "OK", Type = "200" };
            }
            else
            {
                ret = new ApiResult() { Success = false, Msg = "服务器内部错误", Type = "500" };
            }
            return Json(ret);
        }

        [HttpGet]
        public async Task<JsonResult> GetSalesOrderCategoriesByUserId(string userId, string type)
        {
            var result = new ApiResult()
            {
                Data = await _saleOrderRepository.GetSalesOrderCategoriesByUserIdAsync(userId, type),
                Msg = "OK",
                Success = true
            };
            return Json(result);
        }

        [HttpGet]
        public async Task<JsonResult> GetSalesOrderValidationContent(string orderId)
        {
            var result = new ApiResult()
            {
                Data = await _saleOrderRepository.GetSalesOrderValidationContentAsync(orderId),
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
        public async Task<JsonResult> UpdateSalesOrderStatut([FromBody] updateCriteria criteria)
        {
            var status = 0;
            if (criteria.statutCode == "1")
            {
                status = await _saleOrderRepository.SetSenderApplicationAsync(criteria.userId, criteria.orderId, criteria.statutCode,
                    criteria.applicationContent);
            }
            else if (criteria.statutCode == "3")
            {
                status = await _saleOrderRepository.SetFinancialApplicationAsync(criteria.userId, criteria.orderId, criteria.statutCode,
                    criteria.applicationContent);
            }
            else if (criteria.statutCode == "5")
            {
                status = await _saleOrderRepository.SetManagerApplicationAsync(criteria.userId, criteria.orderId, criteria.statutCode,
                    criteria.applicationContent);
            }
            var result = status == 0 ? new ApiResult() { Success = true, Msg = "OK", Type = "200" } : new ApiResult() { Success = false, Msg = "服务器内部错误", Type = "500" };
            return Json(result);
        }

        [HttpPost]
        public async Task<JsonResult> AdvancedSalesOrderSearch([FromBody] AdvancedSalesOrderSearchParam param)
        {
            var result = new ApiResult()
            {
                Data = await _saleOrderRepository.AdvancedSalesOrderSearchAsync(param),
                Msg = "OK",
                Success = true
            };
            return Json(result);
        }
    }
}