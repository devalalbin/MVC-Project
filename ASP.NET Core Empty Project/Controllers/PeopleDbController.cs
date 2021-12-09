using ASP.NET_Core_Empty_Project.Data;
using ASP.NET_Core_Empty_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Controllers
{
    public class PeopleDbController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PeopleDbController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            PeopleViewModelDb vm = new PeopleViewModelDb() { PeopleListView = _context.People.ToList() };
            return View(vm);
        }
        public IActionResult CreatePerson()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePerson(PersonDb person)
        {
            if (ModelState.IsValid)
            {
                _context.People.Add(person);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpPost]
        public IActionResult DeletePerson(string ssn)
        {
            var person = _context.People.Find(ssn);
            _context.Remove(person);
            _context.SaveChanges();
            return RedirectToAction("Index");
        } 
        
        /* public IActionResult Search(string name)
         { [HttpPost]
             PeopleViewModelDb vm = new PeopleViewModelDb();

             //Fill with a list matching our result
             return View();
         }*/
    }
}

