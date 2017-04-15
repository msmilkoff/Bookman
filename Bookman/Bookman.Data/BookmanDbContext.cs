namespace Bookman.Data
{
    using Bookman.Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class BookmanDbContext : IdentityDbContext<User>
    {
        public BookmanDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static BookmanDbContext Create()
        {
            return new BookmanDbContext();
        }
    }
}
