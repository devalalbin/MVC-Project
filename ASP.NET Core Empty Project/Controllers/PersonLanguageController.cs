using ASP.NET_Core_Empty_Project.Data;
using ASP.NET_Core_Empty_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult Index() //creating view with our language with persons list
        {
            var languagesWithPersons = _context.Languages.Include(pl => pl.PersonLanguage)
                .ThenInclude(p => p.Person).ToList();

            PersonLanguageViewModel pvm = new PersonLanguageViewModel();
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
        public ActionResult AddLanguageToPerson(PersonLanguageViewModel languagesVM)
        {
            var person = _context.People.Where(p => p.Name == languagesVM.PersonName).FirstOrDefault();
            var language = _context.Languages.Where(l => l.Id == Int32.Parse(languagesVM.LanguageIdString)).Include(pl => pl.PersonLanguage).FirstOrDefault();

            if (person != null && language != null)
            {
                language.PersonLanguage.Add(new PersonLanguage { PersonId = person.SSN });
                _context.SaveChanges();

            }

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Display()
        {
            var data = _context.PersonLanguage.ToList();
            return View(data);
        }

    }
}
