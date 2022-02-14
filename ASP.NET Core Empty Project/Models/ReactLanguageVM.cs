using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Models
{
    public class ReactLanguageVM
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ReactLanguageVM(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}