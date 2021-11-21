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
            return View();
        }

        [HttpGet]
        public IActionResult GetPeople()
        {
            PersonUtility pu = new PersonUtility();
            List<Person> personList = pu.Read();
            return PartialView("_partialPerson", personList);
        }

        [HttpPost]
        public IActionResult Search()
        {
            PersonUtility pu = new PersonUtility();
            return View();
        }

    }
}
