namespace Bookman.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Bookman.Common;

    internal sealed class Configuration : DbMigrationsConfiguration<BookmanDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BookmanDbContext context)
        {
            this.SeedRole(GlobalConstants.AdminRole, context);
            this.SeedRole(GlobalConstants.AuthorRole, context);
        }

        private void SeedRole(string identityRole, BookmanDbContext context)
        {
            if (!context.Roles.Any(r => r.Name == identityRole))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole(identityRole);

                manager.Create(role);
            }
        }
    }
}
