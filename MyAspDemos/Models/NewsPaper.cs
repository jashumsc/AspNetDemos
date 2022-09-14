using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyAspDemos.Models
{
    [Table("NewsPapers")]
    public class NewsPaper
    {
        [Key]
        public int Id { get; set; }
    }
}
