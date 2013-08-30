using System.Linq;
using MvcApplication1.Entities;

namespace MvcApplication1.DataAccess
{
    public interface IUserDataSource
    {
        IQueryable<User> Users { get; }

        IQueryable<Article> Articles { get; }

        IQueryable<ArticleRate> ArticleRates { get; } 
    }
}
