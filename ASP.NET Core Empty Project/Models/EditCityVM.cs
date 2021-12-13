﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Empty_Project.Models
{
    public class EditCityVm
    {
        public int Id { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "City Name")]
        public string Name { get; set; }
        [Required] public int CountryId { get; set; }
    }
}
