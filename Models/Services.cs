using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Appointer.Models
{
    public class Services
    {
        public string Procedures { get; set; }
        [Required(ErrorMessage ="List the procedures")]
        [StringLength(100)]
        public string Prices { get; set; }
        [Required(ErrorMessage ="List the prices")]
        [StringLength(100)]

    }
}
