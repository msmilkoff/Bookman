namespace Bookman.Services.BookServices
{
    using System.Collections.Generic;
    using System.Linq;
    using AutoMapper;
    using Bookman.Data;
    using Bookman.Models;
    using Bookman.Services.Abstractions;
    using Bookman.ViewModels.Books;

    public class BookService : BaseService, IBookService
    {
        public BookService(IBookmanData data)
            : base(data)
        {
        }

        public IEnumerable<AllBooksViewModel> GetAllBooks()
        {
            var books = this.Data.Books
                .All();

            var booksViewModel = new List<AllBooksViewModel>();
            foreach (var book in books)
            {
                booksViewModel.Add(new AllBooksViewModel
                {
                    CoverImageUrl = book.CoverImageUrl,
                    Description = book.Description,
                    Id = book.Id,
                    Title = book.Title
                });
            }

            return booksViewModel;
        }

        public BookDetailsViewModel GetBookDetails(string title)
        {
            var book = this.Data.Books
                .All()
                .First(b => b.Title == title);

            var bookViewModel = Mapper.Map<Book, BookDetailsViewModel>(book);
            return bookViewModel;
        }
    }
}
