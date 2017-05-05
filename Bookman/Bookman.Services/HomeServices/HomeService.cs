namespace Bookman.Services.HomeServices
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using Bookman.Data;
    using Bookman.Models;
    using Bookman.Services.Abstractions;
    using ViewModels.Home;

    public class HomeService : BaseService, IHomeService
    {
        public HomeService(IBookmanData data)
            :base(data)
        {
        }
        
        public IEnumerable<LatestBookViewModel> GetLatestBooks()
        {
            var latestBooks = this.Data.Books
                .All()
                .OrderByDescending(b => b.DateAdded)
                .Take(4);

            var latestBooksViewModel = new List<LatestBookViewModel>();
            foreach (var book in latestBooks)
            {
                latestBooksViewModel.Add(new LatestBookViewModel
                {
                    Id = book.Id,
                    Title = book.Title,
                    Description = book.Description,
                    CoverImageUrl = book.CoverImageUrl
                });
            }

            return latestBooksViewModel;
        }
    }
}
