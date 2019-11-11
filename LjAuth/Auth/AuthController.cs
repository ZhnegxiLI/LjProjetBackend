using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LjWebApplication.Auth
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthRepository _authRepository;

        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }
        // GET: api/Auth
        [HttpPost]
        public JsonResult Login(string username, string password)
        {
            //TODO: 
            string token = _authRepository.login(username,password);
            // var result = new object();
            return Json(token);
        }

    }
}
