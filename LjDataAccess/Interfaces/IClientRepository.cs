using LjData.Models;
using System.Collections.Generic;

namespace LjDataAccess.Interfaces
{
    public interface IClientRepository
    {
        List<Loctb> GetClientsListByType(string type);

        List<dynamic> GetClieListByVagueNameSearch(int limit);
    }
}