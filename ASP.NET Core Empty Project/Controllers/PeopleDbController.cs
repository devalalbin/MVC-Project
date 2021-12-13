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
    [Authorize(Roles = "Admin, User")]
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
        public IActionResult EditPerson()
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
        public IActionResult EditPerson(EditPersonVM vm)
        {
            if (ModelState.IsValid)
            {
                var person = _context.People.Find(vm.SSN);
                if (person != null)
                {
                    person.Name = vm.Name;
                    person.CityId = vm.CityId;
                    person.PhoneNr = vm.PhoneNumber;
                }
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult DeletePerson(string ssn)
        {
            var person = _context.People.Find(ssn);
            _context.Remove(person);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}

