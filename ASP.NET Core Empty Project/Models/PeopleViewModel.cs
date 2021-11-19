using ASP.NET_Core_Empty_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Models
{
    public class PeopleViewModel : CreatePersonViewModel//container for the information we need in people view. inherits the inputs from our frontend
    {
        public List<Person> PeopleListView { get; set; }
        public string FilterString;
        public PeopleViewModel()
        {
            PeopleListView = new List<Person>();
        }
    }

}
