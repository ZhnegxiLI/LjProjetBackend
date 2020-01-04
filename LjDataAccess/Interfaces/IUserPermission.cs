using System.Collections.Generic;
using LjData.Models;

namespace LjDataAccess.Interfaces
{
    public interface IUserPermission
    {
        List<dynamic> getUserPermissionById(string userId);
        List<MobilePermission> GetPermissionList();

        int SaveUserPermission(UserPermissionParam userPermission);
    }
}