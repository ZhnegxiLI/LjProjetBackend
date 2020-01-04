using LjData.Models;
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

        public List<MobilePermission> GetPermissionList()
        {
            return context.MobilePermission.ToList();
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

        public int SaveUserPermission(UserPermissionParam userPermission)
        {
            int retour = 0;
            if (userPermission.permissionIds!=null && userPermission.permissionIds.Count()>0)
            {
               var u= context.MobileUserPermission.Where(p => p.UserId == userPermission.userId);
                if(u != null&& u.Count()>0)
                {
                    context.MobileUserPermission.RemoveRange(u);
                }

                foreach (var up in userPermission.permissionIds)
                {
                    var permission = new MobileUserPermission();
                    permission.UserId = userPermission.userId;
                    permission.PermissionId = up;
                    context.MobileUserPermission.Add(permission);
                }
                context.SaveChanges();
                retour = 1;
            }

            return retour;
        }
    }
}
