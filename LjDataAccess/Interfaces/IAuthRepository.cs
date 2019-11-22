using System;
using System.Collections.Generic;
using System.Text;
using LjData.Models.ViewModel;

namespace LjDataAccess.Interfaces
{
    public interface IAuthRepository
    {
        dynamic Login(User user);

        List<dynamic> GetUserList();
    }
}
