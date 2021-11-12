using ASP.NET_Core_Empty_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Controllers
{
    public class TestingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TestView()
        {
            ViewBag.Message = PersonModel.WriteMessage(); //can use like this cause write message is static
            return View();
        }
        public IActionResult Person() //get 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Person(string name,int age)//set
        {
            PersonModel pm = new PersonModel();
             pm.Name = name;
             pm.Age = age;

            ViewBag.Message = pm.CheckAge(age);
            return View();
            //return View("Index");
            //return RedirectToAction("Index"); //redirect runs all the code if used
        }
    }
}
