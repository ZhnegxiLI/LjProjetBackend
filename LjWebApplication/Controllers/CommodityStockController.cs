using LjDataAccess.Interfaces;
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


        public class SearchCriteria
        {
            public string CommodityTextSearch { get; set; }
            public string ClientTextSearch { get; set; }
            public string CommodityType { get; set; }
            public int? Start { get; set; }
            public int? Limit { get; set; }
            public string[] clientIdList { get; set; }
            public string[] commodityIdList { get; set; }
        }
        [HttpPost]
        public async Task<ActionResult> GetData([FromBody]SearchCriteria criteria)
        {
            var result = await _commodityStockRepository.GetCommodityStocks(criteria.CommodityTextSearch, criteria.ClientTextSearch, criteria.CommodityType, criteria.clientIdList, criteria.commodityIdList);
            var totalAmount = result.Count();
            if (criteria.Start != null && criteria.Limit != null)
            {
                result = result.Skip((int)criteria.Start * (int)criteria.Limit).Take((int)criteria.Limit).ToList();
            }
            return Ok(new
            {
                TotalAmount = totalAmount,
                Data = result
            });
        }
    }
}
