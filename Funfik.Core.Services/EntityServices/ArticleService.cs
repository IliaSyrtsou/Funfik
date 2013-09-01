using System.Collections.Generic;
using System.Linq;
using Funfik.Core.DataAccess;
using Funfik.Core.Entities;
using Funfik.Core.Interfaces.EntityServiceInterfaces;

namespace Funfik.Core.Services.EntityServices
{
    /// <summary>
    /// A service which provides article-related functionality.
    /// </summary>
    public class ArticleService: IArticleService
    {
        private FunfikDb Database { get; set; }

        public ArticleService()
        {
            Database = new FunfikDb();
        }

        void IArticleService.DeleteArticleByTitle(string title)
        {
            throw new System.NotImplementedException();
        }

        void IArticleService.DeleteTitleById(int id)
        {
            throw new System.NotImplementedException();
        }

        void IArticleService.AddArticle(Article user)
        {
            throw new System.NotImplementedException();
        }

        IEnumerable<Article> IArticleService.GetArticles(int quantity)
        {
            return Database.Articles.OrderByDescending(x => x.ArticleId).Take(quantity);
        }

        Article IArticleService.GetArticleById(int id)
        {
            return Database.Articles.SingleOrDefault(x => x.ArticleId == id);
        }

        IEnumerable<Article> IArticleService.GetArticlesByUserId(int id)
        {
            return Database.Articles.Where(x => x.UserId == id);
        }
    }
}
