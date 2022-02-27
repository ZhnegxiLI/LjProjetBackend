using System.Collections.Generic;

namespace LjData.Models
{
    public class UserPermissionParam
    {
        public string userId { get; set; }
        public List<int> permissionIds { get; set; }


    }
}
