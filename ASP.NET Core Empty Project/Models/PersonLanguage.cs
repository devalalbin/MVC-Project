using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Models
{
    public class PersonLanguage
    {
        public int LanguageId { get; set; }
        public LanguageDb Language { get; set; }

        public string PersonId { get; set; }
        public PersonDb Person { get; set; }
    }
}
