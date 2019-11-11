using System;
using System.Collections.Generic;
using System.Text;
using LjData.Models;

namespace LjDataAccess.Interfaces
{
    public interface IAccountRepository
    {
        List<Account> GetAccounts();
    }
}
