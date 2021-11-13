using ASP.NET_Core_Empty_Project.Models;
using Microsoft.AspNetCore.Http;
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
            ViewBag.Message = PersonModel.WriteMessage();
            return View();
        }
        [HttpPost]
        public IActionResult Person(string name,int age)//set
        {
            HttpContext.Session.SetString("Name", name);
            PersonModel pm = new PersonModel();
             pm.Name = name;
             pm.Age = age;

            ViewBag.Message = pm.CheckAge(age);
            return View();
            //return View("Index");
            //return RedirectToAction("Index"); //redirect runs all the code if used
        }
        public IActionResult SetSession() //example of sending a session from 1 view to another
        {
            HttpContext.Session.SetString("TestSession", "This is a test! ");
            return View();
        }
        public IActionResult GetSession()
        {
            ViewBag.SessionMessage = HttpContext.Session.GetString("TestSession"); // using our session key
            return View();
        }
    }
}
