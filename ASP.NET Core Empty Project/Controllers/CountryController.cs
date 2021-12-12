using Microsoft.AspNetCore.Mvc;
using ASP.NET_Core_Empty_Project.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Core_Empty_Project.Models;

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
        public IActionResult CreateCountry(CountryDb country)
        {
            if (ModelState.IsValid)
            {
                _context.Countries.Add(country);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public IActionResult DeleteCountry(int id)
        {
            var country = _context.Countries.Find(id);
            _context.Remove(country);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
