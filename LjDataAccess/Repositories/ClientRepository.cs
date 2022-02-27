using LjData.Models;
using LjDataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace LjDataAccess.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly ERPDATA2Context context;

        public ClientRepository(ERPDATA2Context context)
        {
            this.context = context;
        }
        public List<dynamic> GetClieListByVagueNameSearch(int limit)
        {
            var result = context.Loctb.Select(p => new
            {
                id = p.LocnLtb,
                name = p.TypeLtb + " - " + p.DescLtb
            });
            return limit != -1 ? result.Take(limit).ToList<dynamic>() : result.ToList<dynamic>();
        }

        public List<Loctb> GetClientsListByType(string type)
        {
            List<Loctb> result = context.Loctb.Where(p => p.TypeLtb == type).OrderBy(p => p.TypeLtb).ToList();
            return result;
        }

        private string GetClientType(string typeId)
        {
            switch (typeId)
            {
                case "C": return "C客户";
                case "S": return "";
                case "V": return "";
                default: return "类型错误";
            }
        }
    }
}
