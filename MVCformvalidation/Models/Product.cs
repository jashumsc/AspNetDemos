using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCformvalidation.Models
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

        #region Navigation Properties to the Master Model - Category


        [Required]
        public int CategoryId { get; set; }


        [ForeignKey(nameof(Product.CategoryId))]
        public Category Category { get; set; }


        #endregion
    }
}
