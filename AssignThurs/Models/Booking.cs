using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;
using System;

namespace AssignThurs.Models
{
    [Table("Bookings")]
    public class Booking
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingId { get; set; }

        [Display(Name ="Booked By")]
        [Required]
        [StringLength(50,ErrorMessage ="{0} cannot be empty")]
        public string BookingName { get; set; }

        [Display(Name = "Booking Date")]
        [Required]
        public DateTime JoinedOn { get; set; }
    }
}
