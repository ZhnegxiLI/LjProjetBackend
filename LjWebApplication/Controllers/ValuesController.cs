﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using LjDataAccess.Interfaces;
using LjDataAccess.Repositories;
using LjWebApplication.Auth;
using LjWebApplication.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace LjWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
   // [EnableCors]
    public class ValuesController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IAccountRepository _accountRepositoryRepository;

        public ValuesController(IStudentRepository studentRepository , IAccountRepository accountRepositoryRepository)
        {
            _studentRepository = studentRepository;
            _accountRepositoryRepository = accountRepositoryRepository;
        }
        // GET api/values
       // [Authorize]
        [HttpGet]
        public JsonResult Get()
        {
            var student = _studentRepository.GetStudent(1);
            //AccountRepository.GetAccounts()
           // _accountRepositoryRepository.GetAccounts()
            return Json(student);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
