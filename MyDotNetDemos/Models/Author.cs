using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyDotNetDemos.Models
{
    [Table("Authors")]
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorId { get; set; }


        [Required]
        [StringLength(30)]
        public string AuthorName { get; set; }

        #region Navigation Properties to the Master Model - Book


        [Required]
        public int BookId { get; set; }


        [ForeignKey(nameof(Author.BookId))]
        public Book Book { get; set; }


        #endregion
    }
}
