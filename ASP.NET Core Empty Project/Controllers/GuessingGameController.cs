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
            int generatedNr = GameModel.GenerateNr();
            HttpContext.Session.SetInt32("Random Number", generatedNr);
            ViewBag.Message = "Guess a number between 1 and 100!";
            return View("Game");
        }
        [HttpPost]
        public IActionResult Game(int guess) //get 
        {
            ViewBag.Message = GameModel.WriteMessage();
            int rndNr = (int)HttpContext.Session.GetInt32("Random Number");
            ViewBag.Message2 = GameModel.CheckNr(guess, rndNr);

            if (guess == rndNr)
            {
               HttpContext.Session.SetInt32("Random Number", GameModel.GenerateNr()); // setting a new value for the random number if user wins
                ViewBag.Message = "Congratulations, Try guessing the new number!";
            }
            return View();

        }
    }
}
