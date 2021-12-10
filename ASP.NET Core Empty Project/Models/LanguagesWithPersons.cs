using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Models
{
    public class LanguagesPeopleList
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public List<PersonDb> People { get; set; }

        public LanguagesPeopleList(int id, string name, List<PersonDb> people)
        {
            Id = id;
            Name = name;
            People = people;
        }
    }
}
