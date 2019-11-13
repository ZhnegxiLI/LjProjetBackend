using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LjData.Models;
using LjDataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using Remotion.Linq.Clauses;

namespace LjDataAccess.Repositories
{
    public class CargoRepository : ICargoRepository
    {
        private readonly ERPDATA2Context context;

        public CargoRepository(ERPDATA2Context context)
        {
            this.context = context;
        }
        public async System.Threading.Tasks.Task<List<Itemmst>> GetCargosListByConditionAsync(string name, string productPlace, string type)
        {
            var result =  (from item in context.Itemmst
                where name == "" || item.DescIt == name && productPlace == "" || item.MadeIt == productPlace &&
                      type == "" || item.TypeIt == type
                select item);

            return await result.ToListAsync();
        }

        public List<dynamic> GetCargosListByNameAsync(string keyword,int limit)
        {
 
            var result = from it in context.Itemmst
                where EF.Functions.Like(it.DescIt, "%" + keyword + "%")
                select new
                {
                    id = it.PartIt,
                    name = it.DescIt,
                    unit = it.UnitIt,
                    typePrice = it.PunitIt
                };
            return limit!=-1? result.Take(limit).ToList<dynamic>(): result.ToList<dynamic>();
        }
    }
}
