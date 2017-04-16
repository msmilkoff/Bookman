namespace Bookman.Data
{
    using System.Data.Entity;
    using Bookman.Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class BookmanDbContext : IdentityDbContext<User>
    {
        public BookmanDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public virtual IDbSet<Author> Authors { get; set; }

        public virtual IDbSet<Book> Books { get; set; }

        public virtual IDbSet<Category> Categories { get; set; }

        public virtual IDbSet<NewsArticle> NewsArticles { get; set; }

        public virtual IDbSet<Order> Orders { get; set; }

        public virtual IDbSet<Review> Reviews { get; set; }


        public static BookmanDbContext Create()
        {
            return new BookmanDbContext();
        }
    }
}
