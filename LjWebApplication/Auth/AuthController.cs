using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LjData.Models.ViewModel;
using LjDataAccess.Interfaces;
using LjWebApplication.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace LjWebApplication.Auth
{
    [Route("api/[controller]/{action}/{id?}")]
    //[ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthRepository _authRepositoryRepository;
        public AuthController(IAuthRepository authRepositoryRepository)
        {
            _authRepositoryRepository = authRepositoryRepository;
        }

        [HttpPost]
        public JsonResult Login([FromBody] User user)
        {
            Object result = new object();
            if (ModelState.IsValid)
            { 
             dynamic token =  _authRepositoryRepository.Login(user);
           
             if (token!=null)
             {
                 result = new ApiResult()
                 {
                     Data = token,
                     Msg = "OK",
                     Success = true
                 };
             }
             else
             {
                 result = new ApiResult()
                 {
                     Msg = "FAIL",
                     Success = false
                 };
             }
            }
            else
            {
                result = new ApiResult()
                {
                    Msg = "FAIL",
                    Success = false
                };
            }

            return Json(result);
        }

        [HttpGet]
        public JsonResult GetUserList()
        {
            var data = _authRepositoryRepository.GetUserList();
            ApiResult result = new ApiResult()
            {
                Msg = "OK",
                Success = true,
                Data = data,
                Type = "200"
            };
            return Json(result);
        }

    }
}
