using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LjData.Models;
using LjDataAccess.Interfaces;

namespace LjDataAccess.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly ERPDATA2Context context;

        public ClientRepository(ERPDATA2Context context)
        {
            this.context = context;
        }
        public List<dynamic> GetClieListByVagueNameSearch(string name, int limit)
        {
            var result = context.Loctb.Where(p=>p.DescLtb.Contains(name)).Select(p => new
            {
                id =  p.LocnLtb,
                name = p.DescLtb
            });
            return limit != -1 ? result.Take(limit).ToList<dynamic>() : result.ToList<dynamic>();
        }

        public List<Loctb> GetClientsListByType(string type)
        {
            List<Loctb> result = context.Loctb.Where(p => p.TypeLtb == type).OrderBy(p => p.TypeLtb).ToList();
            return result;
        }
    }
}
