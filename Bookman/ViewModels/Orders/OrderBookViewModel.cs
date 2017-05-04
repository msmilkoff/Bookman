namespace Bookman.ViewModels.Orders
{
    using System.ComponentModel.DataAnnotations;
    using Bookman.Models;

    public class OrderBookViewModel
    {
        public int BookId { get; set; }

        public string UserId { get; set; }

        public Book Book { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 10)]
        public string Address { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}
