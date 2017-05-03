namespace Bookman.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;
    using Bookman.Services.Abstractions;

    public class HomeController : Controller
    {
        private IHomeService homeService;

        public HomeController(IHomeService homeService)
        {
            this.homeService = homeService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var latestBooks = this.homeService.GetLatestBooks().ToList();

            return View(latestBooks);
        }
    }
}