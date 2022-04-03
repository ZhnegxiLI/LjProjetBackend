using LjData.DtoModels;
using LjData.Models;
using LjDataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LjDataAccess.Repositories
{
    public class CommodityStockRepository : ICommodityStockRepository
    {
        private readonly ERPDATA2Context db;

        public CommodityStockRepository(ERPDATA2Context context)
        {
            this.db = context;
        }
        public async Task<List<CommodityStockDto>> GetCommodityStocks(string CommodityTextSearch, string ClientTextSearch, string CommodityType, string[] clientIdList, string[] commodityIdList)
        {
            var query = (from stock in db.Inven
                         join commodity in db.Itemmst on stock.PartIvn equals commodity.PartIt
                         join client in db.Loctb on stock.LocnIvn equals client.LocnLtb
                         where (CommodityType == null || CommodityType.Length == 0 || commodity.TypeIt.Contains(CommodityType))
                            && (CommodityTextSearch == null || CommodityTextSearch.Length == 0 || commodity.PartIt.Contains(CommodityTextSearch) || commodity.DescIt.Contains(CommodityTextSearch))
                            && (ClientTextSearch == null || ClientTextSearch.Length == 0 || client.LocnLtb.Contains(ClientTextSearch) || client.DescLtb.Contains(ClientTextSearch))
                            && (clientIdList.Length == 0 || clientIdList.Contains(client.LocnLtb))
                            && (commodityIdList.Length == 0 || commodityIdList.Contains(commodity.PartIt))
                         group stock by new { stock.PartIvn, commodity.DescIt, commodity.TypeIt, commodity.UnitIt, commodity.Typ2It } into g
                         select new CommodityStockDto()
                         {
                             CommodityId = g.Key.PartIvn,
                             CommodityLabel = g.Key.DescIt,
                             InitialQuantity = g.Sum(s => s.BivnIvn),
                             CurrentQuantity = g.Sum(s => s.BlceIvn),
                             UnitQuantity = g.Sum(s => s.PckqIvn),
                             CommodityTypeCode = g.Key.TypeIt,
                             CommodityType2Code = g.Key.Typ2It,
                             Unit = g.Key.UnitIt,
                             CommodityTypeLabel = db.Itemtype.Where(x => x.CmpnPty == g.Key.TypeIt).Select(x => x.DescPty).FirstOrDefault(),
                             ProductionDetail = (from pd in db.Ivnloc
                                                 from w in db.Warehouse.Where(x => x.Id == pd.LocnIvl).DefaultIfEmpty()
                                                 where pd.PartIvl == g.Key.PartIvn
                                                 select new CommodityStockProductDetail()
                                                 {
                                                     WarehouseId = pd.LocnIvl,
                                                     WarehouseName = w.Name,
                                                     ProductionNumber = pd.PrdnIvl,
                                                     Quantity = pd.BlceIvl
                                                 }).ToList(),
                             Details = (from detailStock in db.Inven
                                        join detailClient in db.Loctb on detailStock.LocnIvn equals detailClient.LocnLtb
                                        where detailStock.PartIvn == g.Key.PartIvn
                                        select new CommodityStockDetail()
                                        {
                                            InitialQuantity = detailStock.BivnIvn,
                                            CurrentQuantity = detailStock.BlceIvn,
                                            UnitQuantity = detailStock.PckqIvn,
                                            ClientId = detailClient.LocnLtb,
                                            ClientName = detailClient.DescLtb,
                                            ClientShortLabel = detailClient.SdesLtb,
                                            ClientType = detailClient.TypeLtb
                                        }).ToList(),
                         });

            var result = await query.ToListAsync();

            return result;
        }

        public async Task<List<Itemtype>> GetItemType() => await db.Itemtype.ToListAsync();
    }
}
