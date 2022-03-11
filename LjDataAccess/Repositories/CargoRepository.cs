using LjData.Models;
using LjDataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace LjDataAccess.Repositories
{
    public class CargoRepository : ICargoRepository
    {
        private readonly ERPDATA2Context context;

        public CargoRepository(ERPDATA2Context context)
        {
            this.context = context;
        }

        public async System.Threading.Tasks.Task<List<Itemmst>> GetCargosListByConditionAsync(string name,
            string productPlace, string type)
        {
            var result = (from item in context.Itemmst
                          where name == "" || item.DescIt == name && productPlace == "" || item.MadeIt == productPlace &&
                                type == "" || item.TypeIt == type
                          select item);

            return await result.ToListAsync();
        }
        /// <summary>
        /// Get all cargo list
        /// </summary>
        /// <param name="limit"></param>
        /// <returns></returns>
        public List<dynamic> GetCargosListByNameAsync(int limit)
        {
            var result = from it in context.Itemmst
                             // where EF.Functions.Like(it.DescIt, "%" + keyword + "%")
                         select new
                         {
                             id = it.PartIt,
                             name =  it.DescIt,
                             type = it.Typ2It== "R" ? "(材)" :
                             it.Typ2It == "M" ? "(半)" :
                             it.Typ2It == "F" ? "(成)" : null,
                             unit = it.UnitIt,
                             typePrice = it.PunitIt
                         };
            return limit != -1 ? result.Take(limit).ToList<dynamic>() : result.ToList<dynamic>();
        }

        public List<dynamic> GetUnitList()
        {
            var result = context.Units.Select(p => new
            {
                label = p.DescUn,
                equivalence = p.EquivUn
            }).ToList<dynamic>();
            return result;
        }

        /// <summary>
        /// cargo type code-->label
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        private string GetCargoType(string typeId)
        {
            switch (typeId)
            {
                case "R": return "(材)";
                case "M": return "(半)";
                case "F": return "(成)";
                default: return "";
            }
        }
    }
}
