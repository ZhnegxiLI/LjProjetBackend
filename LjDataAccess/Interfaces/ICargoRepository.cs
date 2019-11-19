using LjData.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LjDataAccess.Interfaces
{
    public interface ICargoRepository
    {
        Task<List<Itemmst>> GetCargosListByConditionAsync(string name, string productPlace, string type);

        List<dynamic> GetCargosListByNameAsync(int limit);
    }
}
