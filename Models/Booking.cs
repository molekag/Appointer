using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Linq;
using System.Threading.Tasks;

namespace Appointer.Models
{
    public class Booking
    {
        public DateTime BookingDate { get; set; }
        [Required (ErrorMessage ="Choose date")]
        [StringLength(6)]
        public DateTime BookingTime { get; set; }
        [Required(ErrorMessage ="Choose time")]
        [StringLength(4)]
        public string BookedService { get; set; }
        [Required(ErrorMessage ="Choose service")]
        [StringLength(25)]
        public string Payment { get; set; }
        [Required(ErrorMessage ="Make a payment")]
        [StringLength(20)]
        public string Name { get; set; }
        [Required(ErrorMessage ="Type in name")]
        [StringLength(25)]
        public string Confirmation { get; set; }
    }
}
