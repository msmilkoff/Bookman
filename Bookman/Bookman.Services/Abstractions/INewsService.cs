namespace Bookman.Services.Abstractions
{
    using System.Collections.Generic;
    using Bookman.Models;

    public interface INewsService
    {
        NewsArticle GetArticle(int articleId);

        void PersistArticle(NewsArticle article);

        IEnumerable<NewsArticle> GetAll();
    }
}
