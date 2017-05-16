using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UptimeService.Controllers
{
    public class HomeController : Controller
    {
        private UptimeService.Services.UptimeService uptime;

        public HomeController(UptimeService.Services.UptimeService up)
        {
            uptime = up;
        }

        public IActionResult Index()
        {
            return View(new Dictionary<string, string>
            {
                ["Uptime"] = $"{uptime.Uptime}ms"
            });
        }
    }
}