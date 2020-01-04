using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LjData.Models;
using LjData.Models.ViewModel;
using LjDataAccess.Interfaces;

namespace LjDataAccess.Repositories
{
    public class AccountRepository:IAccountRepository
    {
        private readonly ERPDATA2Context context;

        public AccountRepository(ERPDATA2Context context)
        {
            this.context = context;
        }
        public List<Account> GetAccounts()
        {

            return context.Account.ToList();
        }

    }
}
