﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LjDataAccess.Interfaces;
using LjWebApplication.Model;
using LjWebApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace LjWebApplication.Controllers
{
    [Route("api/[controller]/{action}/{id?}")]
    //[ApiController]
    public class SqlListenerController : Controller
    {
        private readonly ISqlListenerRepository _sqlListenerRepository;
        private NotificationService _notificationService;
        public readonly IConfiguration Configuration;


        public SqlListenerController(ISqlListenerRepository sqlListenerRepository, IConfiguration configuration)
        {
            _sqlListenerRepository = sqlListenerRepository;
            Configuration = configuration;
        }

        [HttpGet]
        public void UpdateOrderStatus(string userId, string orderId, string oldStatusId, string newStatusId, string updateBy, string orderType)
        {
            _sqlListenerRepository.sendNotificationRequest(
                Configuration["JpushConfig:appKey"],
                Configuration["JpushConfig:MasterSecret"],
                userId,
                orderId,
                oldStatusId,
                newStatusId,
                updateBy,
                orderType);
        }
    }
}