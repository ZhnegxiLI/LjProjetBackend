using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LjData.Models.ViewModel;
using LjDataAccess.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace LjWebApplication.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthRepository _authRepositoryRepository;
        public AuthController(IAuthRepository authRepositoryRepository)
        {
            _authRepositoryRepository = authRepositoryRepository;
        }
        // GET: api/Auth
        [HttpPost]
        public async Task<JsonResult> PostAsync([FromForm] User user)
        {
            if (ModelState.IsValid)
            { 
             string token = await _authRepositoryRepository.LoginAsync(user);
             // var result = new object();
             return Json(token);
            }
            else
            {
                //TODO
                return Json("error");
            }
        }

    }
}
