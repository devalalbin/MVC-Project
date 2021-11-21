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

            if (vm.PeopleListView.Count == 0 || vm.PeopleListView == null) // Fills the list with 3 names if emptu (If you delete all people in list it will fill again)
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
            List<Person> people = new List<Person>();
            if (targetPerson != null)
            {
                people.Add(targetPerson);
            }
            return PartialView("_partialPerson", people);
        }

    }
}
