namespace Bookman.Web.Controllers
{
    using System.Web.Mvc;
    using Bookman.Services.Abstractions;

    public class CategoriesController : Controller
    {
        private ICategoryService categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public ActionResult All()
        {
            var categoriesViewModel = this.categoryService.GetAllCategories();

            return View(categoriesViewModel);
        }

        [HttpGet]
        [Route("Categories/Show/{categoryName}")]
        public ActionResult Show(string categoryName)
        {
            ViewBag.CategoryName = categoryName;
            var categoryViewModel = this.categoryService.GetCategoryByName(categoryName);

            return View(categoryViewModel);
        }
    }
}
