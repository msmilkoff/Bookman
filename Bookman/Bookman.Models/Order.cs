namespace Bookman.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 10)]
        public string Address { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        public string UserId { get; set; }

        public virtual User User { get; set; }

        public virtual Book Book { get; set; }

        public int BookId { get; set; }
    }
}