using ASP.NET_Core_Empty_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Models
{
    public class PeopleViewModelDb : CreatePersonViewModel
    {
        public List<PersonDb> PeopleListView { get; set; }
        public string FilterString { get; set; }
        public PeopleViewModelDb()
        {
            PeopleListView = new List<PersonDb>();
        }
       

    }
}
