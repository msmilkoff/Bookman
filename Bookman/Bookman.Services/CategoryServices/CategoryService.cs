namespace Bookman.Services.CategoryServices
{
    using System.Collections.Generic;
    using System.Linq;
    using Bookman.Data;
    using Bookman.Services.Abstractions;
    using Bookman.ViewModels.Categories;

    public class CategoryService : BaseService, ICategoryService
    {
        public CategoryService(IBookmanData data)
            : base(data)
        {
        }

        public IEnumerable<CategoryThumbnailViewModel> GetAllCategories()
        {
            var categories = this.Data.Categories
                .All()
                .Select(c => new
                {
                    Name = c.Name,
                    BookCovers = c.Books
                        .OrderBy(b => b.Title)
                        .Select(b => b.CoverImageUrl),
                    BookTitles = c.Books
                        .OrderBy(b => b.Title)
                        .Select(b => b.Title)
                });

            var allCategoriesViewModel = new List<CategoryThumbnailViewModel>();
            foreach (var category in categories)
            {
                allCategoriesViewModel.Add(new CategoryThumbnailViewModel
                {
                    Name = category.Name,
                    BookCovers = category.BookCovers,
                    BookTitles = category.BookTitles
                });
            }

            return allCategoriesViewModel;
        }

        public CategoryViewModel GetCategoryByName(string categoryName)
        {
            var category = this.Data.Categories
                .All()
                .Where(c => c.Name == categoryName)
                .Select(c => new
                {
                    BookCovers = c.Books
                        .OrderBy(b => b.Title)
                        .Select(b => b.CoverImageUrl),
                    BookTitles = c.Books
                        .OrderBy(b => b.Title)
                        .Select(b => b.Title)
                })
                .First();

            var categoryViewModel = new CategoryViewModel
            {
                BookCovers = category.BookCovers,
                BookTitles = category.BookTitles
            };

            return categoryViewModel;
        }
    }
}
