﻿using System;
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
    [Route("api/[controller]")]
    [ApiController]
    public class UserPermissionController : Controller
    {
        private readonly IUserPermission _userPermissionRepository;

        public UserPermissionController(IUserPermission userPermissionRepository)
        {
            _userPermissionRepository = userPermissionRepository;
        }
        // GET: api/Cargo
        [HttpGet]
        public JsonResult Get(string userId)
        {
            var data = _userPermissionRepository.getUserPermissionById(userId);
            ApiResult result = new ApiResult() { Success = true, Msg = "OK", Type = "200", Data = data };
            return Json(result);
        }
    }
}
