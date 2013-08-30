using System.Data.Entity;
using System.Linq;
using Funfik.Core.Entities;
using Funfik.Core.Interfaces.DataAccessInterfaces;

namespace Funfik.Core.DataAccess
{
    public class FunfikDb : DbContext, IDataSource
    {
        public FunfikDb()
            : base("DefaultConnection")
        {

        }

        public DbSet<User> Users { get; set; }

        private DbSet<Article> Articles { get; set; }

        private DbSet<ArticleRate> ArticleRates { get; set; }

        private DbSet<Category> Categories { get; set; }

        private DbSet<Chapter> Chapters { get; set; }

        private DbSet<Tag> Tags { get; set; }

        IQueryable<User> IDataSource.Users
        {
            get { return Users; }
        }

        IQueryable<Article> IDataSource.Articles
        {
            get { return Articles; }
        }

        IQueryable<ArticleRate> IDataSource.ArticleRates
        {
            get { return ArticleRates; }
        }

        IQueryable<Category> IDataSource.Categories
        {
            get { return Categories; }
        }

        IQueryable<Chapter> IDataSource.Chapters
        {
            get { return Chapters; }
        }

        IQueryable<Tag> IDataSource.Tags
        {
            get { return Tags; }
        }
    }
}