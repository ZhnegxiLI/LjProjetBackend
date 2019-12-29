using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LjWebApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace LjWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : Controller
    {
        private readonly IHubContext<NotificationHub> _notificationHub;

        public NotificationController(IHubContext<NotificationHub> notificationHub)
        {
            _notificationHub = notificationHub;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await _notificationHub.Clients.All.SendAsync("push", new { data = "push event" });
            return Accepted(1);
        }

    }
}