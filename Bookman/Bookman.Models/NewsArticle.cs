namespace Bookman.Models
{
    using System.ComponentModel.DataAnnotations;

    public class NewsArticle
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 20)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }
    }
}
