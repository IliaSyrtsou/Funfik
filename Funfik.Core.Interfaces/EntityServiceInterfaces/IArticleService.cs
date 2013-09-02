using System.Collections.Generic;
using Funfik.Core.Entities;

namespace Funfik.Core.Interfaces.EntityServiceInterfaces
{
    /// <summary>
    /// An interface for article-related functionality.
    /// </summary>
    public interface IArticleService
    {
        /// <summary>
        /// Deletes an article from database by title.
        /// </summary>
        void DeleteArticleByTitle(string title);

        /// <summary>
        /// Deletes an article from database by id.
        /// </summary>
        void DeleteTitleById(int id);

        /// <summary>
        /// Adds article to database.
        /// </summary>
        void AddArticle(Article article);

        /// <summary>
        /// Gets specified number of articles from database.
        /// </summary>
        /// <param name="quantity">Number of users to get.</param>
        IEnumerable<Article> GetArticles(int quantity);

        /// <summary>
        /// Gets an article with given id.
        /// </summary>
        Article GetArticleById(int id);

        /// <summary>
        /// Gets atricles of a user with given id.
        /// </summary>
        IEnumerable<Article> GetUserArticles(int userId);

        /// <summary>
        /// Gets articles with most likes given.
        /// </summary>
        IEnumerable<Article> GetBestArticles();

        /// <summary>
        /// Updates the article in database.
        /// </summary>
        void UpdateArticle(Article article);
    }
}
