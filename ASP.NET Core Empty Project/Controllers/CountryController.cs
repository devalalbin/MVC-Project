using Microsoft.AspNetCore.Mvc;
using ASP.NET_Core_Empty_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Controllers
{
    public class CountryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CountryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Countries.ToList();
            return View(data);
        }

    }
}
