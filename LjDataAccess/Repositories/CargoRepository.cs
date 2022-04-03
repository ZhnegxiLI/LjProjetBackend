using LjDataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace LjDataAccess.Repositories
{
    public class CargoRepository : ICargoRepository
    {
        private readonly ERPDATA2Context context;
        private readonly IUtils utils;

        public CargoRepository(ERPDATA2Context context, IUtils utils)
        {
            this.context = context;
            this.utils = utils;
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
                             name = it.DescIt,
                             type = this.utils.GetCargoType(it.Typ2It),
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
    }
}
