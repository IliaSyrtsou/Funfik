using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        void IArticleService.AddArticle(Article article)
        {
            Database.Articles.Add(article);
            Database.SaveChanges();
        }

        IEnumerable<Article> IArticleService.GetArticles(int quantity)
        {
            return Database.Articles.OrderByDescending(x => x.ArticleId).Take(quantity);
        }

        Article IArticleService.GetArticleById(int id)
        {
            return Database.Articles.SingleOrDefault(x => x.ArticleId == id);
        }

        IEnumerable<Article> IArticleService.GetUserArticles(int id)
        {
            return Database.Articles.Where(x => x.UserId == id);
        }

        IEnumerable<Article> IArticleService.GetBestArticles()
        {
            return (from article in Database.Articles
                    orderby article.Likes.Count descending 
                    select article).Take(10);
        }

        void IArticleService.UpdateArticle(Article article)
        {
            article.LastEditDate = DateTime.Now;
            Database.Entry(article).State = EntityState.Modified;
            Database.SaveChanges();
        }
    }
}
