namespace Bookman.ViewModels.Books
{
    using System.Collections.Generic;
    using Bookman.Models;

    public class BookDetailsViewModel
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Description { get; set; }

        public decimal Price { get; set; }

        public string CoverImageUrl { get; set; }

        public Category Category { get; set; }

        public Author Author { get; set; }

        public IEnumerable<Review> Reviews { get; set; }
    }
}
