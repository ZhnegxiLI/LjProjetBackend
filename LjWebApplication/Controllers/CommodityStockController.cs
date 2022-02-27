using LjData.DtoModels;
using LjDataAccess.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LjWebApplication.Controllers
{
    [Route("api/CommodityStock")]
    [ApiController]
    public class CommodityStockController : ControllerBase
    {
        private readonly ICommodityStockRepository _commodityStockRepository;
        public CommodityStockController(ICommodityStockRepository commodityStockRepository)
        {
            _commodityStockRepository = commodityStockRepository;
        }

   
        [HttpGet]
        public async Task<IEnumerable<CommodityStockDto>> GetData(string CommodityTextSearch, string ClientTextSearch, string CommodityType)
        {
            return await _commodityStockRepository.GetCommodityStocks(CommodityTextSearch, ClientTextSearch, CommodityType);
        }
    }
}
