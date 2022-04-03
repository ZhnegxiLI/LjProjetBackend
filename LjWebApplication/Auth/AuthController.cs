using LjData.Models.ViewModel;
using LjDataAccess.Interfaces;
using LjWebApplication.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace LjWebApplication.Auth
{
    [Route("api/[controller]")]
    //[ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthRepository _authRepositoryRepository;
        public AuthController(IAuthRepository authRepositoryRepository)
        {
            _authRepositoryRepository = authRepositoryRepository;
        }

        [Route("Login")]
        [HttpPost]
        public JsonResult Login([FromBody] User user)
        {
            Object result = new object();
            if (ModelState.IsValid)
            {
                dynamic token = _authRepositoryRepository.Login(user);
                if (token != null)
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

        //TODO ONLY FOR TEST
        [Route("CheckAvailabilityOfToken")]
        [Authorize]
        [HttpGet]
        public JsonResult CheckAvailabilityOfToken(string token)
        {
            return Json(new ApiResult()
            {
                Msg = "OK",
                Success = true,
                Data = "",
                Type = "200"
            });
        }

        [Route("GetUserList")]
        [HttpGet]
        public JsonResult GetUserList()
        {
            var data = _authRepositoryRepository.GetUserList();
            //ApiResult result = new ApiResult()
            //{
            //    Msg = "OK",
            //    Success = true,
            //    Data = data,
            //    Type = "200"
            //};
            return Json(data);
        }

    }
}
