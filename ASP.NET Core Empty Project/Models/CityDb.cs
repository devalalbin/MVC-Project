using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Models
{
    public class CityDb
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public CountryDb Country { get; set; }
        public ICollection<PersonDb> Persons { get; set; }
    }
}
