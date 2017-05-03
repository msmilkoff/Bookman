namespace Bookman.Web.Controllers
{
    using System;
    using System.Linq;
    using System.Web.Mvc;
    using Bookman.Services.Abstractions;

    public class BooksController : Controller
    {
        private IBookService bookService;

        public BooksController(IBookService bookService)
        {
            this.bookService = bookService;
        }
        
        [HttpGet]
        public ActionResult All()
        {
            var viewModel = this.bookService.GetAllBooks();

            return View(viewModel);
        }

        [HttpGet]
        [Route("Books/Details/{title}")]
        public ActionResult Details(string title)
        {
            var viewModel = this.bookService.GetBookDetails(title);

            return View(viewModel);
        }
    }
}