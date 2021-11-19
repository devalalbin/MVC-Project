

using ASP.NET_Core_Empty_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Models
{
    public  class PersonUtility //container for the information we need in people view.
    {
        public static List<Person> peopleList = new List<Person>();
        private static int idCounter;

        public void GeneratePeople()
        {
            PersonUtility peopleViewModel = new PersonUtility();
            peopleViewModel.Create("Albin de Val", "0701020304", "Göteborg");
            peopleViewModel.Create("Sven Svensson", "12345678", "London");
            peopleViewModel.Create("Johan Johansson", "098746234", "New York");

        }

        public Person Create(string name, string phoneNr, string city)
        {
            Person newPerson = new Person(name, phoneNr, city, idCounter);
            peopleList.Add(newPerson);
            idCounter++;
            return newPerson;
        }

        public bool Delete(Person person)
        {
            bool status = peopleList.Remove(person);
            return status;
        }


        public List<Person> Read() //read our list of persons
        {
            return peopleList;
        }

        public Person Read(int id)
        {
            Person targetPerson = peopleList.Find(c => c.Id == id);
            return targetPerson;
        }


    }
}
