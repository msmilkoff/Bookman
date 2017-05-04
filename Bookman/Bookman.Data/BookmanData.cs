namespace Bookman.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Validation;
    using System.Linq;
    using Bookman.Models;

    /// <summary>
    /// Unit Of Work
    /// </summary>
    public class BookmanData : IBookmanData
    {
        private readonly DbContext context;

        private readonly Dictionary<Type, object> repositories = new Dictionary<Type, object>();

        public BookmanData(DbContext context)
        {
            this.context = context;
        }

        public IRepository<User> Users => this.GetRepository<User>();

        public IRepository<Author> Authors => this.GetRepository<Author>();

        public IRepository<Book> Books => this.GetRepository<Book>();

        public IRepository<Category> Categories => this.GetRepository<Category>();

        public IRepository<NewsArticle> NewsArticles => this.GetRepository<NewsArticle>();

        public IRepository<Order> Orders => this.GetRepository<Order>();

        public IRepository<Review> Reviews => this.GetRepository<Review>();

        public DbContext Context => this.context;

        public int SaveChanges()
        {
            try
            {
                return this.context.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }

        public void Dispose()
        {
            this.Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.context?.Dispose();
            }
        }

        private IRepository<T> GetRepository<T>()
            where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(GenericRepository<T>);
                this.repositories.Add(typeof(T), Activator.CreateInstance(type, this.context));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }
    }
}
