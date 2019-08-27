using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Appointer.Models
{
    public class LogIn
    {
        public string FullName { get; set; }
        [Required(ErrorMessage = "Provide full name")]
        [StringLength(100)]
        public string LogInEmail { get; set; }
        [Required(ErrorMessage = "Provide email")]
        [StringLength(100)]
    }
}
