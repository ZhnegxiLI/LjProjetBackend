﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LjData.Models;
using LjDataAccess.Interfaces;

namespace LjDataAccess.Repositories
{
    public class AccountRepositoryRepository:IAccountRepository
    {
        private readonly ERPDATA2Context context;

        public AccountRepositoryRepository(ERPDATA2Context context)
        {
            this.context = context;
        }
        public List<Account> GetAccounts()
        {
            return context.Account.ToList();
        }
    }
}
