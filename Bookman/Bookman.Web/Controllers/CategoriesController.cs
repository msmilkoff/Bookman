namespace Bookman.Web.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Mvc;
    using Bookman.Data;
    using Bookman.Web.Models;

    public class CategoriesController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            var db = new BookmanDbContext();
            var categoryNames = db.Categories.Select(c => c.Name).ToList();

            var model = new AllCategoriesViewModel()
            {
                Categories = new List<string>(categoryNames)
            };

            return View(model);
        }
    }
}
