using System.Web.Security;
using WebMatrix.WebData;

namespace Funfik.Core.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Funfik.Core.Interfaces.DataAccessInterfaces;

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

            var membership = (SimpleMembershipProvider)Membership.Provider;

            var db = (IDataSource) context;
            db.ArticleRates.Add();
            membership.CreateUserAndAccount("test1", "test1");
            membership.CreateUserAndAccount("test2", "test2");
            membership.CreateUserAndAccount("test3", "test3");
            membership.CreateUserAndAccount("test4", "test4");
        }
    }
}
