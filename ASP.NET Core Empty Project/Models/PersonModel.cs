using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Models
{
    public class PersonModel
    {
        public string Name { get; set; }
        public int Age { get; set; }


        public static string WriteMessage()
        {
            return "Please enter your name and age!";
        }
        public string CheckAge(int age)
        {
            string message;
            if (age >= 18)
            {
                message = "You are allowed to vote!";
            }
            else { 
                message = "You are too young to vote!";
            }
            return message;
        }
    }
}

