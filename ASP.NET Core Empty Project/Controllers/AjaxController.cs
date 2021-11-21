using ASP.NET_Core_Empty_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ASP.NET_Core_Empty_Project.Controllers
{
    public class AjaxController : Controller
    {
        public IActionResult Index()
        {
            PersonUtility pu = new PersonUtility();

            PeopleViewModel vm = new PeopleViewModel() { PeopleListView = pu.Read() }; //returns the list of persons we created

            if (vm.PeopleListView.Count == 0 || vm.PeopleListView == null) // Fills the list with 3 names if empty
            {
                pu.GeneratePeople();
            }
            return View(vm);
        }

        [HttpGet]
        public IActionResult GetPeople()
        {
            PersonUtility pu = new PersonUtility();
            List<Person> personList = pu.Read();
            return PartialView("_partialPerson", personList);
        }

        [HttpPost]
        public IActionResult Search(int personId)
        {
            PersonUtility pu = new PersonUtility();
            Person targetPerson = pu.Read(personId);
            List<Person> people = new List<Person>(); //making a list of 1 person, since our partialview takes list of persons
            if (targetPerson != null)
            {
                people.Add(targetPerson);
            }
            return PartialView("_partialPerson", people);
        }

        [HttpPost]
        public IActionResult DeletePerson(int personId)
        {
            PersonUtility pu = new PersonUtility();
            Person targetPerson = pu.Read(personId);
            Console.WriteLine("this is the ID we wanna delete" + targetPerson);
            bool success = false;
            if(targetPerson != null)
            {
                success = pu.Delete(targetPerson);
            }
            if (success) // if deletion did not work, return error codes
            {
                return StatusCode(200);
            }
            return StatusCode(404);
        }

    }
}
