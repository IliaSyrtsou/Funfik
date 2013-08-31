using System.Data.Entity;
using Funfik.Core.Entities;

namespace Funfik.Core.DataAccess
{
    public class FunfikDb : DbContext
    {
        public FunfikDb()
            : base("DefaultConnection")
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Article> Articles { get; set; }

        public DbSet<ArticleRate> ArticleRates { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Chapter> Chapters { get; set; }

        public DbSet<Tag> Tags { get; set; }

    }
}