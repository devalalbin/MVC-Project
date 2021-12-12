using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Models
{
    public class PersonLanguageViewModel
    {
        public string PersonName { get; set; }
        public string LanguageName { get; set; }
        public List<LanguagesPeopleList> LanguagesWithPersonsList { get; set; }

        public string LanguageIdString { get; set; }
   
    }
}
