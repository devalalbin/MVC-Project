using ASP.NET_Core_Empty_Project.Data;
using ASP.NET_Core_Empty_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Controllers
{
    public class DbController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DbController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<PersonDb> ListOfPeople = _context.People.ToList();
            return View(ListOfPeople);
        }
    }
}
