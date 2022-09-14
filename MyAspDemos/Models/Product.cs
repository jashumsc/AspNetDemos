using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyAspDemos.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int ProductId { get; set; }

        [Required(ErrorMessage = "{0} cannot be empty")]
        [StringLength(60)]

        public string ProductName { get; set; }
    }
}
