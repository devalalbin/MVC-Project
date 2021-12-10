using ASP.NET_Core_Empty_Project.Data;
using ASP.NET_Core_Empty_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


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
            var languagesWithPersons = _context.Languages.Include(pl => pl.PersonLanguage)
                .ThenInclude(p => p.Person).ToList();

            PersonLanguageViewModel pvm = new PersonLanguageViewModel();
            pvm.CreateLanguagesSelectList(languagesWithPersons);
            List<LanguagesPeopleList> languagesWithPersonsList = new List<LanguagesPeopleList>();

            foreach (var item in languagesWithPersons)
            {
                var languagesPerson = item.PersonLanguage.Select(l => l.Person).ToList();
                languagesWithPersonsList.Add(new LanguagesPeopleList(item.Id, item.Name, languagesPerson));
            }

            pvm.LanguagesWithPersonsList = languagesWithPersonsList;
            return View(pvm);
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
        public ActionResult AddLanguageToPerson(PersonLanguageViewModel lvm)
        {
            var person = _context.People.Where(p => p.SSN == lvm.PersonName).FirstOrDefault();
            var language = _context.Languages.Where(l => l.Id == Int32.Parse(lvm.LanguageIdString)).Include(pl => pl.PersonLanguage).FirstOrDefault();

            if (person != null && language != null)
            {
                language.PersonLanguage.Add(new PersonLanguage { PersonId = person.SSN });
                _context.SaveChanges();

            }

            return RedirectToAction(nameof(Index));
        }
    }
}
