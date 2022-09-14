using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MyAspDotNet.Models;

namespace MyAspDotNet.Models
{
    [Table("Categories")]
    public class Category
    {
        [Key]                                                           // Primary Key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]           // Identity (1,1)
        public int CategoryId { get; set; }


        [Required(ErrorMessage = "{0} cannot be empty.")]
        [StringLength(60, ErrorMessage = "{0} cannot have more than {1} characters.")]
        public string CategoryName { get; set; }
    }
}
