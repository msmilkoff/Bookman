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
                .Take(3);

            var latestBooksViewModel = Mapper.Map<IEnumerable<Book>, IEnumerable<LatestBookViewModel>>(latestBooks);
            return latestBooksViewModel;
        }
    }
}
