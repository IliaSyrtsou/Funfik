using System.Linq;
using Funfik.Core.Entities;

namespace Funfik.Core.DataAccess
{
    public interface IUserDataSource
    {
        IQueryable<User> Users { get; }

        IQueryable<Article> Articles { get; }

        IQueryable<ArticleRate> ArticleRates { get; } 
    }
}
