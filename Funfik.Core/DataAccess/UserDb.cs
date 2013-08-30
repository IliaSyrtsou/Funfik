using System.Data.Entity;
using System.Linq;
using Funfik.Core.Entities;

namespace Funfik.Core.DataAccess
{
    public class UserDb : DbContext, IUserDataSource
    {
        public UserDb()
            : base("DefaultConnection")
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleRate> ArticleRates { get; set; }

        IQueryable<User> IUserDataSource.Users
        {
            get { return Users; }
        }

        IQueryable<Article> IUserDataSource.Articles
        {
            get { return Articles; }
        }

        IQueryable<ArticleRate> IUserDataSource.ArticleRates
        {
            get { return ArticleRates; }
        }
    }
}