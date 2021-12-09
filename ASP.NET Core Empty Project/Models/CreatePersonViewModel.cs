using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace ASP.NET_Core_Empty_Project.Models
{
    public class CreatePersonViewModel
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter a name"),  MinLength(3)]
        [Display(Name =" Name")]
        public string Name { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter a phone number"),  MinLength(3)]
        [Display(Name = "Phone Number")]
        public string PhoneNr { get; set; }

        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter a a city name"),  MinLength(3)]
        [Display(Name = "City Id")]
        public int CityId { get; set; } 
       
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Please enter a social security number"), MinLength(13)]
        [Display(Name = "SSN")]
        public string SSN { get; set; }
    }
}
