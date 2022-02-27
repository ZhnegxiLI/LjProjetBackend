using LjData.Models;
using System.Collections.Generic;

namespace LjDataAccess.Interfaces
{
    public interface IAccountRepository
    {
        List<Account> GetAccounts();

    }
}
