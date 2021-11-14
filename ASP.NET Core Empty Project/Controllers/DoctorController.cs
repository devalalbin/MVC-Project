using Microsoft.AspNetCore.Mvc;
using ASP.NET_Core_Empty_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Controllers
{
    public class DoctorController : Controller
    {
        public IActionResult FeverCheck() //get 
        {
             ViewBag.Message = FeverModel.WriteMessage();
            return View();
        }

        [HttpPost]
        public IActionResult FeverCheck(int temp) //get 
        {
            FeverModel fm = new FeverModel();
            fm.Temp = temp;

            ViewBag.Message = fm.CheckTemp(temp);
            return View();

        }
    }
}
