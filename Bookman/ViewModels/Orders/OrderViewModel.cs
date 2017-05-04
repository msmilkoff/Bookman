using Bookman.Models;

namespace Bookman.ViewModels.Orders
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        
        public string Address { get; set; }
        
        public string Email { get; set; }
        
        public string PhoneNumber { get; set; }

        public string UserId { get; set; }
        
        public int BookId { get; set; }

        public Book Book { get; set; }
    }
}
