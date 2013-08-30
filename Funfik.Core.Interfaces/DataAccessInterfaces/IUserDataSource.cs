using System.Linq;
using Funfik.Core.Entities;

namespace Funfik.Core.Interfaces.DataAccessInterfaces
{
    /// <summary>
    /// An interface which provides access to the database elements.
    /// </summary>
    public interface IDataSourcev
    {
        IQueryable<User> Users { get; }

        IQueryable<Article> Articles { get; }

        IQueryable<ArticleRate> ArticleRates { get; }

        IQueryable<Category> Categories { get; }

        IQueryable<Chapter> Chapters { get; }

        IQueryable<Tag> Tags { get; } 
    }
}
