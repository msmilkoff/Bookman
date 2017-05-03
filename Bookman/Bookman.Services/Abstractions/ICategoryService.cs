namespace Bookman.Services.Abstractions
{
    using System.Collections.Generic;
    using Bookman.ViewModels.Categories;

    public interface ICategoryService
    {
        IEnumerable<CategoryThumbnailViewModel> GetAllCategories();

        CategoryViewModel GetCategoryByName(string categoryName);
    }
}
