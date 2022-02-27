using LjData.Models;
using LjDataAccess;
using LjDataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LjWebApplication.Test
{
    public class CommodityStockRepositoryTest
    {
        private ERPDATA2Context db;
        private CommodityStockRepository _commodityStockRepository;

        [SetUp]
        public void Setup()
        {
            var build = new DbContextOptionsBuilder<ERPDATA2Context>().UseInMemoryDatabase("ERPDATA");
            db = new ERPDATA2Context(build.Options);

            // REMOVE ALL DATA BEFORE EVERY TEST 
            db.Database.EnsureDeleted();
            // TODO PLACE IN A COMMON FUNCTION 
            // INSERT MOCK DATA 

            // INSERT ITEMTYPE(Commodity type)
            db.Itemtype.AddRange(new List<Itemtype>()
            {
                new Itemtype() { CmpnPty = "0001", DescPty = "坯布"},
                new Itemtype() { CmpnPty = "0002", DescPty = "棉纱"},
            });

            // INSERT ITEMST DATA(Commodity)
            db.Itemmst.AddRange(new List<Itemmst>()
            {
                new Itemmst(){ PartIt="000010001", DescIt="C40 紧密赛络纺", UnitIt="公斤",TypeIt="0002",Typ2It="R" },
                new Itemmst(){ PartIt="000010002", DescIt="JC32", UnitIt="公斤",TypeIt="0002",Typ2It="R" },
                new Itemmst(){ PartIt="000010003", DescIt="OE10", UnitIt="公斤",TypeIt="0001",Typ2It="R" },
                new Itemmst(){ PartIt="000010004", DescIt="OE7", UnitIt="公斤",TypeIt="0001",Typ2It="R" },
            });

            // INSERT LOCTB(Client)
            db.Loctb.AddRange(new List<Loctb>()
            {
                new Loctb() {LocnLtb="96033", DescLtb="大耀印染厂", SdesLtb="大耀印染厂", TypeLtb = "S"},
                new Loctb() {LocnLtb="00055", DescLtb="江苏沙印集团射阳印染有限公司", SdesLtb="江苏沙印集团射阳印染有限公司", TypeLtb = "S"},
                new Loctb() {LocnLtb="96001", DescLtb="佛山艺品服饰", SdesLtb="佛山艺品服饰", TypeLtb = "S"},
                new Loctb() {LocnLtb="96002", DescLtb="佛山卓纺纺织有限公司", SdesLtb="卓纺纺织", TypeLtb = "S"},
            });

            // INSERT INVEN(Commodity stock)
            db.Inven.AddRange(new List<Inven>()
            {
                new Inven() {PartIvn = "000010001", LocnIvn="96033", BivnIvn = 20, BlceIvn = 15, PckqIvn = 2},
                new Inven() {PartIvn = "000010001", LocnIvn="00055", BivnIvn = 30, BlceIvn = 11, PckqIvn = 2},

                new Inven() {PartIvn = "000010002", LocnIvn="96001", BivnIvn = 15, BlceIvn = 10, PckqIvn = 2},
                new Inven() {PartIvn = "000010003", LocnIvn="00055", BivnIvn = 40, BlceIvn = 11, PckqIvn = 2},

                new Inven() {PartIvn = "000010004", LocnIvn="96001", BivnIvn = 15, BlceIvn = 10, PckqIvn = 2},
                new Inven() {PartIvn = "000010004", LocnIvn="96002", BivnIvn = 40, BlceIvn = 11, PckqIvn = 2},
            });

            db.SaveChanges();

            _commodityStockRepository = new CommodityStockRepository(db);
        }


        [Test]
        [TestCase("", "", "")]
        [TestCase(null, null, null)]
        public async Task Run_GetCommodityStocks_WithoutParams_ReturnAllItemsAsync(string CommodityTextSearch, string ClientTextSearch, string CommodityType)
        {
            var numberOfCommodityInStock = db.Inven.Select(x => x.PartIvn).Distinct().Count();

            var count = (await _commodityStockRepository.GetCommodityStocks(CommodityTextSearch, ClientTextSearch, CommodityType)).Count;
            Assert.AreEqual(numberOfCommodityInStock, count);
        }

        [TestCase("")]
        [TestCase(null)]
        [TestCase("C40")]
        [TestCase("OE7")]
        [TestCase("JC32")]
        [TestCase("C40 紧密赛络纺")]
        [TestCase("000010001")]
        [TestCase("000010002")]
        [TestCase("000010003")]
        [TestCase("000010004")]
        [TestCase("0000")]
        [TestCase("10004")]
        [Test]
        public async Task Run_GetCommodityStocks_WithCommodityTextSearch_ReturnAllStockContainsSearchContentAsync(string CommodityTextSearch)
        {
            var commodityStocks = (from cs in db.Inven
                                   join client in db.Loctb on cs.LocnIvn equals client.LocnLtb
                                   join c in db.Itemmst on cs.PartIvn equals c.PartIt
                                   where CommodityTextSearch == null || CommodityTextSearch == "" || c.PartIt.Contains(CommodityTextSearch) || c.DescIt.Contains(CommodityTextSearch)
                                   select cs.PartIvn).Distinct();
            var result = await _commodityStockRepository.GetCommodityStocks(CommodityTextSearch, null, null);
            // Check if result list corresponds the search param 
            Assert.That(result.All(x => CommodityTextSearch == null || CommodityTextSearch == "" || x.CommodityId.Contains(CommodityTextSearch) || x.CommodityLabel.Contains(CommodityTextSearch)));
            // Check if some result not in the list 
            Assert.AreEqual(result.Count, commodityStocks.Count());
        }

        [TestCase("")]
        [TestCase(null)]
        [TestCase("大耀印染厂")]
        [TestCase("江苏沙印集团射阳印染有限公司")]
        [TestCase("佛山")]
        [TestCase("佛山艺品服饰")]
        [TestCase("卓纺")]
        [TestCase("96033")]
        [TestCase("00055")]
        [TestCase("96001")]
        [TestCase("96001")]
        [TestCase("96002")]
        [Test]
        public async Task Run_GetCommodityStocks_WithClientTextSearch_ReturnAllStockContainsSearchContentAsync(string ClientTextSearch)
        {
            var commodityStocks = (from cs in db.Inven
                                   join client in db.Loctb on cs.LocnIvn equals client.LocnLtb
                                   join c in db.Itemmst on cs.PartIvn equals c.PartIt
                                   where ClientTextSearch == null || ClientTextSearch == "" || client.LocnLtb.Contains(ClientTextSearch) || client.DescLtb.Contains(ClientTextSearch)
                                   select cs.PartIvn).Distinct().Count();
            var result = await _commodityStockRepository.GetCommodityStocks(null, ClientTextSearch, null);

            // Check if result list corresponds the search param 
            Assert.That(result.All(x => ClientTextSearch == null || ClientTextSearch == "" || x.Details.Where(p => p.ClientId.Contains(ClientTextSearch)).Count() > 0 || x.Details.Where(p => p.ClientName.Contains(ClientTextSearch)).Count() > 0));
            // Check if some result not in the list 
            Assert.AreEqual(commodityStocks, result.Count);
        }

        [TestCase("")]
        [TestCase(null)]
        [TestCase("0001")]
        [TestCase("0002")]
        [Test]
        public async Task Run_GetCommodityStocks_WithCommodityType_ReturnAllStockContainsSearchContentAsync(string CommodityType)
        {
            var commodityStocks = (from cs in db.Inven
                                   join client in db.Loctb on cs.LocnIvn equals client.LocnLtb
                                   join c in db.Itemmst on cs.PartIvn equals c.PartIt
                                   where CommodityType == null || CommodityType == "" || c.TypeIt.Contains(CommodityType)
                                   select cs.PartIvn).Distinct();
            var result = await _commodityStockRepository.GetCommodityStocks(null, null, CommodityType);
            // Check if result list corresponds the search param 
            Assert.That(result.All(x => CommodityType == null || CommodityType == "" || x.CommodityTypeCode.Contains(CommodityType)));
            // Check if some result not in the list 
            Assert.AreEqual(result.Count, commodityStocks.Count());
        }
    }
}