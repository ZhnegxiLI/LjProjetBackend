using System;
using System.Collections.Generic;
using System.Text;
using LjData.Models;

namespace LjDataAccess.Interfaces
{
    public interface IClientRepository
    {
        List<Loctb> GetClientsListByType(string type);

        List<dynamic> GetClieListByVagueNameSearch(string name, int limit);
    }
}