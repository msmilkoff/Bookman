﻿namespace Bookman.Models
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Collections.Generic;
    using System.Security.Claims;
    using System.Threading.Tasks;

    public class User : IdentityUser
    {
        private ICollection<Book> favouriteBooks;
        private ICollection<Order> orders;

        public User()
        {
            this.favouriteBooks = new HashSet<Book>();
            this.orders = new HashSet<Order>();
        }

        public virtual ICollection<Book> FavouriteBooks
        {
            get { return this.favouriteBooks; }
            set { this.favouriteBooks = value; }
        }

        public virtual ICollection<Order> Orders
        {
            get { return this.orders; }
            set { this.orders = value; }
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }
}
