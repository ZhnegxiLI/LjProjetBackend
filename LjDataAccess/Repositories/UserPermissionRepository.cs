using LjDataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace LjDataAccess.Repositories
{
    public class UserPermission : IUserPermission
    {
        private readonly ERPDATA2Context context;

        public UserPermission(ERPDATA2Context context)
        {
            this.context = context;
        }

        public List<dynamic> getUserPermissionById(string userId)
        {
            var result = from up in context.MobileUserPermission
                join p in context.MobilePermission on up.PermissionId equals p.Id
                where up.UserId == userId
                select new
                {
                    userId = up.UserId,
                    permissionId = p.Id,
                    permissionCode = p.Code,
                    permissionLabel = p.Label
                };
            return result.ToList<dynamic>();
        }
    }
}
