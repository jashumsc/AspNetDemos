using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace MyAspDemos.Models
{
    [Table("Books")]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookId { get; set; }


        [Required]
        [StringLength(100)]
        public string BookTitle { get; set; }


        [Required]
        [DefaultValue(1)]
        public int NumberOfCopies { get; set; } = 1;


        [Required]
        [DefaultValue(true)]
        public bool IsEnabled { get; set; }



        #region Navigation Properties to the Master Model - Category


        [Required]
        public int CategoryId { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        [ForeignKey(nameof(Book.CategoryId))]
        public Category Category { get; set; }


        #endregion

        #region Navigation Properties to the Transaction Model - Author

        public ICollection<Author> Authors { get; set; }

        #endregion


    }
}