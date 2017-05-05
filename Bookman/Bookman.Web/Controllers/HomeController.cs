namespace Bookman.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Bookman.Services.Abstractions;

    public class HomeController : Controller
    {
        private IHomeService homeService;
        private INewsService newsService;

        public HomeController(IHomeService homeService, INewsService newsService)
        {
            this.homeService = homeService;
            this.newsService = newsService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var latestBooks = this.homeService
                .GetLatestBooks()
                .ToList();

            return View(latestBooks);
        }
    }
}