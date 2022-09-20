using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignThurs.Models
{
    [Table("Bikes")]
    public class Bike
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int BikeId { get; set; }

        [Required]
        [StringLength(30)]
        public string BikeName { get; set; }


        [Display(Name = "Choose the photo for bike")]
        [Required]
        [NotMapped]
        public IFormFile BikePhoto { get; set; }

        public string BikePicUrl { get; set; }
    }
}
