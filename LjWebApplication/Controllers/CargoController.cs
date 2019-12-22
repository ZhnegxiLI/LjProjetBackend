using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LjDataAccess.Interfaces;
using LjWebApplication.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LjWebApplication.Controllers
{
    [Route("api/[controller]/{action}/{id?}")]
    //[ApiController]
    [Authorize]
    //[EnableCors]
    public class CargoController : Controller
    {
        private readonly ICargoRepository _cargoRepository;
     
        public CargoController(ICargoRepository cargoRepository)
        {
            _cargoRepository = cargoRepository;
        }
        // GET: api/Cargo
        [HttpGet]
        public JsonResult GetCargo(int limit)
        {
            var data =  _cargoRepository.GetCargosListByNameAsync(limit);
            ApiResult result = new ApiResult() { Success = true, Msg = "OK", Type = "200", Data = data };
            return Json(result);
        }
        [AllowAnonymous]
        [HttpGet]
        public JsonResult GetUnitList()
        {
            var data = _cargoRepository.GetUnitList();
            ApiResult result = new ApiResult() { Success = true, Msg = "OK", Type = "200", Data = data };
            return Json(result);
        }

    }
}
