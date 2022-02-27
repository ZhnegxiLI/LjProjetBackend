using LjData.Models;
using LjDataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace LjDataAccess.Repositories
{
    public class AccountRepository : IAccountRepository
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
