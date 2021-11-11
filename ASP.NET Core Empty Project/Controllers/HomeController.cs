using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.test = "This is a test";
            return View();
        }
    }
}
