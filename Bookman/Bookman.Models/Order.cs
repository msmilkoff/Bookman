namespace Bookman.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Order
    {
        private ICollection<Book> orderedBooks;

        public Order()
        {
            this.orderedBooks = new HashSet<Book>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 20)]
        public string Address { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        public int UserId { get; set; }


        public virtual User User { get; set; }

        public virtual ICollection<Book> OrderedBooks
        {
            get { return this.orderedBooks; }
            set { this.orderedBooks = value; }
        }
    }
}