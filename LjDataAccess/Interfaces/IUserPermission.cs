using LjData.Models;
using System.Collections.Generic;

namespace LjDataAccess.Interfaces
{
    public interface IUserPermission
    {
        List<dynamic> getUserPermissionById(string userId);
        List<MobilePermission> GetPermissionList();

        int SaveUserPermission(UserPermissionParam userPermission);
    }
}