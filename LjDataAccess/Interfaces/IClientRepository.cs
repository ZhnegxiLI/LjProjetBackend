using System.Collections.Generic;

namespace LjDataAccess.Interfaces
{
    public interface IClientRepository
    {
        List<dynamic> GetClieListByVagueNameSearch(int limit);
    }
}