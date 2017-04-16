namespace Bookman.Data
{
    using System.Data.Entity;
    using Bookman.Models;

    /// <summary>
    /// Unit of Work Interface
    /// </summary>
    public interface IBookmanData
    {
        IRepository<Author> Authors { get; }

        IRepository<Book> Books { get; }

        IRepository<Category> Categories { get; }

        IRepository<NewsArticle> NewsArticles { get; }

        IRepository<Order> Orders { get; }

        IRepository<Review> Reviews { get; }

        IRepository<User> Users { get; }

        DbContext Context { get; }

        void Dispose();

        int SaveChanges();
    }
}