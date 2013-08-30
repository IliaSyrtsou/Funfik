using System.Data.Entity;
using Funfik.Core.DataAccess;
using WebMatrix.WebData;

namespace Funfik.Web.App_Start
{
    public class DatabaseConfig
    {
        public static void Initialize()
        {
            WebSecurity.InitializeDatabaseConnection("DefaultConnection", "Users", "UserId", "UserName", autoCreateTables: true);
            Database.SetInitializer(new CreateDatabaseIfNotExists<FunfikDb>());
        }
    }
}