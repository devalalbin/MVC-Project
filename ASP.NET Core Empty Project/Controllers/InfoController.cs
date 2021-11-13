using ASP.NET_Core_Empty_Project.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Controllers
{
    public class InfoController : Controller
    {
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Project()
        {
            return View();
        }
    }
}
