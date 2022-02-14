using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Models
{
    public class ReactVM
    {
        public List<ReactPeopleVM> ReactPeople { get; set; }

        public List<ReactCityVM> ReactCities { get; set; }
    }
}