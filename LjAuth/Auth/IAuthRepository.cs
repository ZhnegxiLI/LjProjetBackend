using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LjWebApplication.Auth
{
    public interface IAuthRepository
    {
        string login(string username, string password);

        //bool IsValidUserAndPasswordCombination(string username, string password);

        //string GenerateToken(string username);
    }
}
