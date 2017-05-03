namespace Bookman.Services.Abstractions
{
    using System.Collections.Generic;
    using Bookman.ViewModels.Books;

    public interface IBookService
    {
        IEnumerable<AllBooksViewModel> GetAllBooks();

        BookDetailsViewModel GetBookDetails(string title);
    }
}
