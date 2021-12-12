using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Models
{
    public class LanguagesPeopleList //list containing people for each languague
    {

        public int LanguageId { get; set; }
        public string LanguageName { get; set; }
        public List<PersonDb> People { get; set; }

        public LanguagesPeopleList(int id, string name, List<PersonDb> people)
        {
            LanguageId = id;
            LanguageName = name;
            People = people;
        }
    }
}
