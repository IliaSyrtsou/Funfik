using System.Web.Security;
using WebMatrix.WebData;

namespace Funfik.Core.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Funfik.Core.DataAccess.UserDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(Funfik.Core.DataAccess.UserDb context)
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
        }
    }
}
