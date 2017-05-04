namespace Bookman.Services.Abstractions
{
    using Bookman.Models;

    public interface INewsService
    {
        NewsArticle GetArticle(int articleId);

        void PersistArticle(NewsArticle article);
    }
}
