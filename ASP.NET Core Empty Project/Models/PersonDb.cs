using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_Empty_Project.Models
{
    [Table("People")]
    public class PersonDb
    {
        [Key]
        [MaxLength(13,ErrorMessage = "Need to be a valid SSN")]
        public string SSN { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string PhoneNr { get; set; }
        public int CityId { get; set; }
        [ForeignKey("CityId")]

        public CityDb City { get; set; }

        public ICollection<PersonLanguage> PersonLanguage { get; set; }

    }
}
