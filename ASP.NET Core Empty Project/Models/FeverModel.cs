using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Models
{
    public class FeverModel
    {
        public int Temp { get; set; }


        public static string WriteMessage()
        {
            return "Enter your temprature!";
        }
        public string CheckTemp(int temp)
        {
            string message;
            if (temp >= 38)
            {
                message = "Sadly you seem to have a fever, go see a doctor!";
            }
            if (temp <= 35)
            {
                message = "Sadly you seem to have hypothermia, go see a doctor quickly!";
            }
            else {
                message = "You are healthy!";
            }
            return message;
        }
    }
}

