using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LjDataAccess;
using LjDataAccess.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LjWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : Controller
    {
      
        private readonly IClientRepository  _clientRepository;
        public ClientController(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        // GET: api/Client
        [HttpGet]
        public JsonResult Get(int limit)
        {
            var result = _clientRepository.GetClieListByVagueNameSearch(limit);
            return Json(result);
        }

    }
}
