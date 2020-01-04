using System;
using System.Collections.Generic;
using System.Text;

namespace LjData.Models
{
    public class UserPermissionParam
    {
        public string userId  { get; set; }
        public List<int> permissionIds { get; set; }


    }
}
