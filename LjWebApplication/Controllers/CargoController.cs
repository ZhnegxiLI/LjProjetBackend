using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LjDataAccess.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LjWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
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
        public JsonResult Get(string keyword,int limit)
        {
     
           var result =  _cargoRepository.GetCargosListByNameAsync(keyword,limit);
           return Json(result);
        }

    }
}
