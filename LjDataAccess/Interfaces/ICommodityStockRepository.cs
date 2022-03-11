using LjData.DtoModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LjDataAccess.Interfaces
{
    public interface ICommodityStockRepository
    {
  
        Task<List<CommodityStockDto>> GetCommodityStocks(string CommodityTextSearch, string ClientTextSearch, string CommodityType, string[] clientIdList, string[] commodityIdList);
    }
}
