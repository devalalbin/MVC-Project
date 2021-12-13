using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Models
{
    public class EditPersonVM
    {
        [Required] [DisplayName("Name")] public string Name { get; set; }
        [Required] public string SSN { get; set; }
        [Required] [DisplayName("City Id")] public int CityId { get; set; }
        [Required] public List<int> Languages { get; set; }
        [Required] [DisplayName("Phone Number")] public string PhoneNumber { get; set; }
        
    }
}
