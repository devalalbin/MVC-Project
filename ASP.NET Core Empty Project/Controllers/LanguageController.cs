using ASP.NET_Core_Empty_Project.Data;
using ASP.NET_Core_Empty_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Controllers
{
    public class LanguageController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LanguageController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Languages.ToList();
            return View(data);
        }
        public IActionResult CreateLanguage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateLanguage(LanguageDb language)
        {
            if (ModelState.IsValid)
            {
                _context.Languages.Add(language);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpPost]
        public IActionResult DeleteLanguage(int id)
        {
            var langugage = _context.Languages.Find(id);
            _context.Remove(langugage);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
