using ASP.NET_Core_Empty_Project.Data;
using ASP.NET_Core_Empty_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using React;


namespace ASP.NET_Core_Empty_Project.Controllers
{
    public class ReactController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ReactController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
               
        public List<ReactCityVM> GetCitysList() //list of citys
        {
            var citiesList = _context.Cities.ToList();
            var reactCityVMList = new List<ReactCityVM>();
            foreach (var item in citiesList)
            {
                reactCityVMList.Add(new ReactCityVM(item.Id, item.Name));
            }
            return reactCityVMList;
        }

        public List<ReactPeopleVM> GetPersonWithLanguage() //List with people + languages
        {
            var peopleWithLangList = _context.People.Include(p => p.City).Include(pl => pl.PersonLanguage)
                .ThenInclude(l => l.Language).ToList();

            var reactPersonVMList = new List<ReactPeopleVM>();

            foreach (var item in peopleWithLangList)
            {
                var pl = item.PersonLanguage.Select(p => p.Language).ToList();
                var reactLanguageVMList = new List<ReactLanguageVM>();
                foreach (var lang in pl)
                {
                    reactLanguageVMList.Add(new ReactLanguageVM(lang.Id, lang.Name));
                }
                reactPersonVMList.Add(new ReactPeopleVM(item.SSN, item.Name, item.PhoneNr, item.City.Name, reactLanguageVMList));
            }
            return reactPersonVMList;
        }


        [HttpGet]
        public IActionResult GetPeopleList() 
        {
            ReactVM reactVM = new ReactVM();
            reactVM.ReactPeople = GetPersonWithLanguage();

            reactVM.ReactCities = GetCitysList();

            return Json(reactVM);
        }
    
        [HttpPost]
        public IActionResult DeletePerson([FromBody] PersonDb person)
        {
            var pers = _context.People.Find(person.SSN);
            if (person == null)
            {
                return NotFound();
            }
            _context.Remove(pers);
            _context.SaveChanges();
            return Ok();
        } 
    }
}
