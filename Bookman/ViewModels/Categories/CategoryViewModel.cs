namespace Bookman.ViewModels.Categories
{
    using System.Collections.Generic;

    public class CategoryViewModel
    {
        public IEnumerable<string> BookCovers { get; set; }

        public IEnumerable<string> BookTitles { get; set; }
    }
}
