using ASP.NET_Core_Empty_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Controllers
{
    public class PeopleController : Controller
    {
        public IActionResult People()
        {
            PersonUtility personUtility = new PersonUtility();

            PeopleViewModel peopleListViewModel = new PeopleViewModel() { PeopleListView = personUtility.Read() }; //returns the list of persons we created
        
            if (peopleListViewModel.PeopleListView.Count == 0 || peopleListViewModel.PeopleListView == null) // Fills the list with 3 names if emptu (If you delete all people in list it will fill again)
            {
                personUtility.GeneratePeople();
            }
            return View(peopleListViewModel);
        }
        [HttpPost]
        public IActionResult CreatePerson(CreatePersonViewModel createPerson)
        {
            PeopleViewModel vm = new PeopleViewModel();
            PersonUtility pu = new PersonUtility();

            if (ModelState.IsValid)
            {
                vm.Name = createPerson.Name;
                vm.PhoneNr = createPerson.PhoneNr;
                vm.City = createPerson.City;
                vm.PeopleListView = pu.Read();

                pu.Create(createPerson.Name, createPerson.PhoneNr, createPerson.City);
                ViewBag.Message = "Added person! ";
                return View("People", vm);
            }
            else { ViewBag.Message = "Failed to add person, Try again!"; }
            vm.PeopleListView = pu.Read();
            return View("People",vm);
        }

        public IActionResult DeletePerson(int id)
        {
            PersonUtility pu = new PersonUtility();
            Person targetPerson = pu.Read(id);
            pu.Delete(targetPerson);
            return RedirectToAction("People");
        }
    }

}
