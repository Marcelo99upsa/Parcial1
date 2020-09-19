using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ParcialMarceloOrtiz.Models
{
    public class Country
    {
        [Key]
        [Required(ErrorMessage = "You must enter the field {0}")]
        [Range(1,9999)]
        public int Alpha3Code { get; set; }

        [Required(ErrorMessage = "You must enter the field {0}")]
        public string Region { get; set; }

        [Required(ErrorMessage = "You must enter the field {0}")]
        [StringLength(30,ErrorMessage ="The field {0} must must contain betwen {2} and {1} characters",MinimumLength =2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "You must enter the field {0}")]
        public string Area { get; set; }

        [Required(ErrorMessage ="You must enter the field {0}")]
        public int Callingcodes { get; set; }

        [Required(ErrorMessage = "You must enter the field {0}")]
        public string Languajes { get; set; }

        [Required(ErrorMessage = "You must enter the field {0}")]
        public string flag { get; set; }
    }
}