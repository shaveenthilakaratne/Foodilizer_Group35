using Foodilizer_Group35.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Foodilizer_Group35.Controllers
{
    public class Customer_profileController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public Customer_profileController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult customer_profile()
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
