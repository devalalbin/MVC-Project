using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string PhoneNr { get; set; }
        public string City { get; set; }
        private readonly int _id;
        public int Id{get { return _id; }
        }

        public Person(string name, string phoneNr, string city, int id)
        {
            Name = name;
            PhoneNr = phoneNr;
            City = city;
            this._id = id;
        }

    }
}