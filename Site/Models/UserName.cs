using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Site.Models
{
    public class UserName
    {
        [Required(ErrorMessage ="Please enter you name")]
        [RegularExpression("^[A-Z][a-z]+", ErrorMessage = "Please enter a valid name")]
        public string Name { get; set; }
    }
}
