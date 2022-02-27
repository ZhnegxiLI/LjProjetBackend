using LjDataAccess.Interfaces;
using LjWebApplication.Model;
using Microsoft.AspNetCore.Mvc;

namespace LjWebApplication.Controllers
{
    [Route("api/[controller]/{action}/{id?}")]
    public class VersionController : Controller
    {
        private readonly IVersionRepository _versionRepository;

        public VersionController(IVersionRepository versionRepository)
        {
            _versionRepository = versionRepository;
        }
        // GET: api/Cargo
        [HttpGet]
        public JsonResult GetVersion()
        {
            var data = _versionRepository.getMobileVersion();
            ApiResult result = new ApiResult() { Success = true, Msg = "OK", Type = "200", Data = data };
            return Json(result);
        }
        [HttpGet]
        public JsonResult GetCompanyName()
        {
            var data = _versionRepository.getCompanyName();
            ApiResult result = new ApiResult() { Success = true, Msg = "OK", Type = "200", Data = data };
            return Json(result);
        }

    }
}
