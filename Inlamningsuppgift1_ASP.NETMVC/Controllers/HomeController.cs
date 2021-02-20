using Inlamningsuppgift1_ASP.NETMVC.Data;
using Inlamningsuppgift1_ASP.NETMVC.Models;
using Inlamningsuppgift1_ASP.NETMVC.Services;
using Inlamningsuppgift1_ASP.NETMVC.Services.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Inlamningsuppgift1_ASP.NETMVC.Controllers
{

    [Authorize(Roles = "Admin")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IIdentityService _identityService;

        public HomeController(ILogger<HomeController> logger, IIdentityService identityService)
        {
            _logger = logger;
            _identityService = identityService;
        }

        public async Task <IActionResult> Index()
        {
            await _identityService.CreateRootAccountAsync();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
