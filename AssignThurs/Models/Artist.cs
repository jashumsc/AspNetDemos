using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssignThurs.Models
{
    [Table("Artists")]
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }

        [Display(Name ="Tatoo Artist")]
        [Required]
        public string ArtistName { get; set; }


    }
}
