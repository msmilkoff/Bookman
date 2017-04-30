namespace Bookman.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using Bookman.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<BookmanDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BookmanDbContext context)
        {
        //    this.SeedCategories(context);
        //    context.SaveChanges();
        }

        private void SeedCategories(BookmanDbContext context)
        {
            //context.Categories.AddOrUpdate(c => c.Name,
            //    new Category
            //    {
            //        Name = "Fantasy"
            //    },
            //    new Category
            //    {
            //        Name = "Horror"
            //    },
            //    new Category
            //    {
            //        Name = "Science-Fiction"
            //    },
            //    new Category
            //    {
            //        Name = "Classics"
            //    },
            //    new Category
            //    {
            //        Name = "Historical"
            //    },
            //    new Category
            //    {
            //        Name = "Mystery"
            //    },
            //    new Category
            //    {
            //        Name = "Poetry"
            //    },
            //    new Category
            //    {
            //        Name = "Romance"
            //    },
            //    new Category
            //    {
            //        Name = "Non-Fiction"
            //    },
            //    new Category
            //    {
            //        Name = "Comedy"
            //    });
        }
    }
}
