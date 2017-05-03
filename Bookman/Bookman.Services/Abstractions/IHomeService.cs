namespace Bookman.Services.Abstractions
{
    using System.Collections.Generic;
    using ViewModels.Home;

    public interface IHomeService
    {
        IEnumerable<LatestBookViewModel> GetLatestBooks();
    }
}
