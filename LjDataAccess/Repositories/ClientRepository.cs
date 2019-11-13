using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LjData.Models;
using LjDataAccess.Interfaces;

namespace LjDataAccess.Repositories
{
    class ClientRepository : IClientRepository
    {
        private readonly ERPDATA2Context context;

        public ClientRepository(ERPDATA2Context context)
        {
            this.context = context;
        }
        public List<Loctb> GetClieListByVagueNameSearch(string name)
        {
            List<Loctb> result = context.Loctb.Where(p=>p.DescLtb.Contains(name)) .ToList();
            return result;
        }

        public List<Loctb> GetClientsListByType(string type)
        {
            List<Loctb> result = context.Loctb.Where(p => p.TypeLtb == type).OrderBy(p => p.TypeLtb).ToList();
            return result;
        }
    }
}
