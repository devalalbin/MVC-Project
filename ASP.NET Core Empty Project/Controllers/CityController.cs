using ASP.NET_Core_Empty_Project.Data;
using ASP.NET_Core_Empty_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Controllers
{
    [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
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
        [Authorize(Roles = "Admin")]
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
