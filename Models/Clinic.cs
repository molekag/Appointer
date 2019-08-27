using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Threading.Tasks;

namespace Appointer.Models
{
    public class Clinic
    {
        public string About { get; set; }
        [Required(ErrorMessage = "Description")]
        [StringLength(100)]
        public string Address { get; set; }
        [Required(ErrorMessage = "Set address")]
        [StringLength(100)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Set email")]
        [StringLength(30)]
        public string ContactNumber { get; set; }
        [Required(ErrorMessage = "Set telephone number")]
        [StringLength(12)]
        public string Team { get; set; }
        [Required(ErrorMessage = "List memebrs of clinic")]
        [StringLength(100)]
    }
}

