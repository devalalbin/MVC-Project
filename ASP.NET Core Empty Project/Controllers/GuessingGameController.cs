using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET_Core_Empty_Project.Models;
using Microsoft.AspNetCore.Http;

namespace ASP.NET_Core_Empty_Project.Controllers
{
    public class GuessingGameController : Controller
    {
        [HttpGet]
        public IActionResult Game()
        {
            int rndNr = GameModel.GenerateNr();
            HttpContext.Session.SetInt32("Random Number", rndNr);
            ViewBag.Message = "Guess a number between 1 and 100!";
            return View("Game");
        }
        [HttpPost]
        public IActionResult Game(int guess) //get 
        {
            int rndNr = (int)HttpContext.Session.GetInt32("Random Number");
            ViewBag.Message = GameModel.CheckNr(guess, rndNr);
            return View();

        }
    }
}
