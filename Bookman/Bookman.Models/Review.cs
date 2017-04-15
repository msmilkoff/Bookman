namespace Bookman.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Review
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        [StringLength(1000, MinimumLength = 20)]
        public string Content { get; set; }

        public BookRating Rating { get; set; }

        public virtual User User { get; set; }

        public int BookId { get; set; }

        public virtual Book Book { get; set; }
    }
}