using System;
using System.Web.Security;
using Funfik.Core.Entities;
using WebMatrix.WebData;

namespace Funfik.Core.DataAccess.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<Funfik.Core.DataAccess.FunfikDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Funfik.Core.DataAccess.FunfikDb context)
        {
            WebSecurity.InitializeDatabaseConnection("DefaultConnection", "Users", "UserId", "Username", autoCreateTables: true);

            if (!Roles.RoleExists("Administrator"))
            {
                Roles.CreateRole("Administrator");
            }

            if (Membership.GetUser("mr.God", false) == null)
            {
                WebSecurity.CreateUserAndAccount("mr.God", "12345");
                Roles.AddUsersToRoles(new[] { "mr.God" }, new[] { "Administrator" });
            }

            #region Seeding Categories

            context.Categories.AddOrUpdate(category => category.CategoryId,
                                           new Category() {CategoryId = 1, Name = "Adventure"},
                                           new Category() {CategoryId = 2, Name = "Sci-Fi"},
                                           new Category() {CategoryId = 3, Name = "Fantasy"},
                                           new Category() {CategoryId = 4, Name = "Action"},
                                           new Category() {CategoryId = 5, Name = "Other"});
            #endregion


            #region Seeding Users

            for (int i = 1; i < 15; i++)
            {

                WebSecurity.CreateUserAndAccount("test" + i.ToString(), "test", new { Email = "test" + i.ToString() + "@test.test" });
            }

            #endregion

            #region Seeding Articles

            for (int i = 1; i < 15; i++)
            {
                context.Articles.AddOrUpdate(article => article.ArticleId,
                                             new Article()
                                                 {
                                                     ArticleId = i,
                                                     UserId = i,
                                                     Title = "Title"+i.ToString(),
                                                     Annotation = "Annotation"+i.ToString(),
                                                     CategoryId = new Random().Next(1, 5),
                                                     CreationDate = DateTime.Now,
                                                     LastEditDate = DateTime.Now
                                                 });  
            }
            for (int i = 16; i < 30; i++)
            {
                context.Articles.AddOrUpdate(article => article.ArticleId,
                                             new Article()
                                             {
                                                 ArticleId = i,
                                                 UserId = 30-i,
                                                 Title = "Title" + i.ToString(),
                                                 Annotation = "Annotation" + i.ToString(),
                                                 CategoryId = new Random().Next(1, 5),
                                                 CreationDate = DateTime.Now,
                                                 LastEditDate = DateTime.Now
                                             });
            }

            #endregion

            #region Seeding Chapters
            for (int i = 1; i < 30; i++)
            {
                context.Chapters.AddOrUpdate(chapter => chapter.ChapterId,
                    new Chapter()
                        {
                            ChapterId = i,
                            ArticleId = i,
                            Title = "SomeChapter" + i.ToString(),
                            Text = i.ToString() + "Some long" + i.ToString() + " interesting and fascinating content"
                        });
            }

            for (int i = 31; i < 60; i++)
            {
                context.Chapters.AddOrUpdate(chapter => chapter.ChapterId,
                    new Chapter()
                    {
                        ChapterId = i,
                        ArticleId = 60-i,
                        Title = "SomeChapter" + i.ToString(),
                        Text = i.ToString() + "Some long" + i.ToString() + " interesting and fascinating content"
                    });
            }
            #endregion

            context.SaveChanges();
        }
    }
}
