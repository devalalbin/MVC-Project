using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Models
{
    public class ReactCityVM
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ReactCityVM(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}