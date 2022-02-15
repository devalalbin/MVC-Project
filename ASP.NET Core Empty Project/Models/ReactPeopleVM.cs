using ASP.NET_Core_Empty_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Models
{
    public class ReactPeopleVM
    {
        public string SSN { get; set; }
        public string Name { get; set; }
        public string PhoneNr { get; set; }

        public string CityName { get; set; }
        public int CityId { get; set; }
        public List<ReactLanguageVM> Language { get; set; }
        public ReactPeopleVM()
        {

        }

        public ReactPeopleVM(string ssn, string name, string phoneNr, string cityName, List<ReactLanguageVM> language)
        {
            SSN = ssn;
            Name = name;
            PhoneNr = phoneNr;
            CityName = cityName;
            Language = language;
        }
    }
}