using System;
using System.Collections.Generic;
using System.Text;
using LjData.Models;
using LjData.Models.ViewModel;

namespace LjDataAccess.Interfaces
{
    public interface IAccountRepository
    {
        List<Account> GetAccounts();

    }
}
