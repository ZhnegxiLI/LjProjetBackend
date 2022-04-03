using System.Collections.Generic;

namespace LjDataAccess.Interfaces
{
    public interface ICargoRepository
    {
        List<dynamic> GetCargosListByNameAsync(int limit);

        List<dynamic> GetUnitList();
    }
}
