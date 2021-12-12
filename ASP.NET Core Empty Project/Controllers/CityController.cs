using ASP.NET_Core_Empty_Project.Data;
using ASP.NET_Core_Empty_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Controllers
{
    public class CityController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CityController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var listOfCitys = _context.Cities.ToList();
            return View(listOfCitys);
        }
        public IActionResult CreateCountry(CityDb city)
        {
            if (ModelState.IsValid)
            {
                _context.Cities.Add(city);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public IActionResult DeleteCity(int id)
        {
            var city = _context.Cities.Find(id);
            _context.Remove(city);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
