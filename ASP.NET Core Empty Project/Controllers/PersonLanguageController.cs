using ASP.NET_Core_Empty_Project.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Controllers
{
    public class PersonLanguageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PersonLanguageController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.PersonLanguage.ToList();
            return View(data);
        }
    }
}
