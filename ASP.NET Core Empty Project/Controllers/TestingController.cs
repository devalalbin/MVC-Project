/*
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
            ViewBag.Message = FeverModel.WriteMessage(); //can use like this cause write message is static
            return View();
        }
        public IActionResult Person() //get 
        {
            ViewBag.Message = FeverModel.WriteMessage();
            return View();
        }
        [HttpPost]
        public IActionResult Person(int temp)//set
        {
            //HttpContext.Session.SetString("Name", name);
            FeverModel pm = new FeverModel();
             pm.Temp = temp;

            ViewBag.Message = pm.CheckTemp(age);
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
*/