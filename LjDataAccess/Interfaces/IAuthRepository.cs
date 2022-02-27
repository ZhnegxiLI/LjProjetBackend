using LjData.Models.ViewModel;
using System.Collections.Generic;

namespace LjDataAccess.Interfaces
{
    public interface IAuthRepository
    {
        dynamic Login(User user);

        List<dynamic> GetUserList();
    }
}
