using LjData.Models;
using LjDataAccess.Interfaces;
using LjWebApplication.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LjWebApplication.Controllers
{
    [Route("api/[controller]/{action}/{id?}")]
    [Authorize]
    public class PermissionController : Controller
    {
        private readonly IUserPermission _userPermission;

        public PermissionController(IUserPermission permissionRepository)
        {
            _userPermission = permissionRepository;
        }
        // GET: api/Cargo
        [HttpGet]
        public JsonResult GetPermissionList()
        {
            var data = _userPermission.GetPermissionList();
            //ApiResult result = new ApiResult() { Success = true, Msg = "OK", Type = "200", Data = data };
            return Json(data);
        }
        [HttpGet]
        public JsonResult GetUserPermissionById(string userId)
        {
            var data = _userPermission.getUserPermissionById(userId);
            ApiResult result = new ApiResult() { Success = true, Msg = "OK", Type = "200", Data = data };
            return Json(result);
        }

        [HttpPost]
        public JsonResult SaveUserPermission([FromBody] UserPermissionParam userPermission)
        {
            var data = _userPermission.SaveUserPermission(userPermission);
            ApiResult result = new ApiResult() { Success = true, Msg = "OK", Type = "200", Data = data };
            return Json(result);
        }


    }
}
