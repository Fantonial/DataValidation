using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FormDataValidation.Models
{
    public class PersonModel
    {
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public DateTime DOB { get; set; }

        [Required]
        [Range(18, 60)]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public int Contact { get; set; }

        [Required]
        public string School { get; set; }

    }
}
