namespace Bookman.Services.NewsService
{
    using System.Linq;
    using Bookman.Data;
    using Bookman.Models;
    using Bookman.Services.Abstractions;

    public class NewsService : BaseService, INewsService
    {
        public NewsService(IBookmanData data) : base(data)
        {
        }

        public NewsArticle GetArticle(int articleId)
        {
            var article = this.Data.NewsArticles
                .All()
                .First(a => a.Id == articleId);

            return article;
        }

        public void PersistArticle(NewsArticle article)
        {
            this.Data.NewsArticles.Add(article);
            this.Data.SaveChanges();
        }
    }
}
