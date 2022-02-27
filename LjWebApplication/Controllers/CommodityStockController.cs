using LjData.DtoModels;
using LjDataAccess.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LjWebApplication.Controllers
{
    [Route("api/commodity-stock")]
    [ApiController]
    public class CommodityStockController : ControllerBase
    {
        private readonly ICommodityStockRepository _commodityStockRepository;
        public CommodityStockController(ICommodityStockRepository commodityStockRepository)
        {
            _commodityStockRepository = commodityStockRepository;
        }

   
        [HttpGet]
        public async Task<ActionResult> GetData(string CommodityTextSearch, string ClientTextSearch, string CommodityType, int? Start, int? Limit)
        {
            var result = await _commodityStockRepository.GetCommodityStocks(CommodityTextSearch, ClientTextSearch, CommodityType);
            var totalAmount = result.Count();
            if (Start!=null && Limit != null)
            {
                result = result.Skip((int)Start * (int)Limit).Take((int)Limit).ToList();
            }
            return Ok(new
            {
                TotalAmount = totalAmount,
                Data = result
            });
        }
    }
}
