using System;
using System.Collections.Generic;
using System.Text;
using LjData.Models.ViewModel;

namespace LjDataAccess.Interfaces
{
    public interface IAuthRepository
    {
        System.Threading.Tasks.Task<string> LoginAsync(User user);
    }
}
