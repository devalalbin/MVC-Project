using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Models
{
    public class GameModel
    {
        public static int count = 0;

        public static string WriteMessage()
        {
            return "Enter a number between 1 and 100";
        }
        public static int GenerateNr() //generating our random nr
        {
            Random rand = new Random();
            int rndNr = rand.Next(1, 100);
            count = 0; // reset guess counter every time a new number is generated
            return rndNr;
        }
        public static string CheckNr(int guess,int rndNr)
        {
            count++;
            string message;
            if (guess > 100)
            {
                message = "Your number is too large! Please guess again";
            }
            else if (guess < 1)
            {
                message = "Your number is too small! Please guess again";
            }
            else
            {
                if(guess == rndNr)
                {
                    message = "You guessed correctly!! it was " + rndNr+" You guessed it correctly in " + count + " guesses!";
                    count = 0;
                }
                else if (guess > rndNr)
                {
                    message = "Your guess is higher then the number, try again!";
                }
                else
                {
                    message = "Your guess is lower then the number, try again!";
                }
            }
            return message;
        }
    }
}

