namespace Bookman.ViewModels.Categories
{
    using System.Collections.Generic;

    public class CategoryThumbnailViewModel
    {
        public string Name { get; set; }

        public IEnumerable<string> BookCovers { get; set; }

        public IEnumerable<string> BookTitles { get; set; }
    }
}
