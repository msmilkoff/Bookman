namespace Bookman.Web.Controllers
{
    using System.Web.Mvc;
    using System.Web.Mvc.Expressions;
    using Bookman.Common;
    using Bookman.Models;
    using Bookman.Services.Abstractions;

    public class NewsController : Controller
    {
        private INewsService newsService;

        public NewsController(INewsService newsService)
        {
            this.newsService = newsService;
        }

       [HttpGet]
       [Authorize(Roles = GlobalConstants.AuthorRole)]
        public ActionResult WriteArticle()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = GlobalConstants.AuthorRole)]
        public ActionResult WriteArticle(NewsArticle model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.RedirectToAction<HomeController>(c => c.Index());
            }

            this.newsService.PersistArticle(model);
            return this.RedirectToAction<NewsController>(c => c.Details(model.Id));
        }

        [HttpGet]
        [Route("News/Details{id}")]
        public ActionResult Details(int id)
        {
            var model = this.newsService.GetArticle(id);

            return View(model);
        }
    }
}