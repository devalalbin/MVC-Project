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
            PersonUtility pu = new PersonUtility(); 

            PeopleViewModel vm = new PeopleViewModel() { PeopleListView = pu.Read() }; //returns the list of persons we created
        
            if (vm.PeopleListView.Count == 0 || vm.PeopleListView == null) // Fills the list with 3 names if emptu (If you delete all people in list it will fill again)
            {
                pu.GeneratePeople();
            }
            return View(vm);
        }
        [HttpPost]
        public IActionResult CreatePerson(CreatePersonViewModel createPerson)
        {
            PeopleViewModel vm = new PeopleViewModel();
            PersonUtility pu = new PersonUtility();

            if (ModelState.IsValid)
            {
                vm.PeopleListView = pu.Read();
                pu.Create(createPerson.Name, createPerson.PhoneNr, createPerson.City); // adds a person to our list
                ViewBag.Message = "Added person! ";
                return View("People", vm);
            }
            else { ViewBag.Message = "Failed to add person, Try again!"; }
            vm.PeopleListView = pu.Read();
            return View("People",vm);
        }

        [HttpPost]
        public IActionResult Search(PeopleViewModel viewModel) 
        {
            PersonUtility pu = new PersonUtility();
            viewModel.PeopleListView.Clear(); //clear our list and fills it only with search results that matches

            foreach (Person p in pu.Read())
            {
                if (p.Name.Contains(viewModel.FilterString, StringComparison.OrdinalIgnoreCase) || p.City.Contains(viewModel.FilterString, StringComparison.OrdinalIgnoreCase)) //searches name or city
                {
                    viewModel.PeopleListView.Add(p);
                }
            }
            return View("People",viewModel);
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
