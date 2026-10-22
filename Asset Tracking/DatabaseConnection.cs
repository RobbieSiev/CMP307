using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;

namespace Asset_Tracking
{
    public static class DatabaseConnection
    {
        private const string Username = "mssql2401087";
        private const string Password = "pzjAQZ6zsU";

        public static dbEntities CreateContext()
        {
            string entityConnectionString =
                ConfigurationManager
                    .ConnectionStrings["dbEntities"]
                    .ConnectionString;

            var entityBuilder =
                new EntityConnectionStringBuilder(entityConnectionString);

            var sqlBuilder =
                new SqlConnectionStringBuilder(entityBuilder.ProviderConnectionString)
                {
                    UserID = Username,
                    Password = Password
                };

            entityBuilder.ProviderConnectionString = sqlBuilder.ConnectionString;

            return new dbEntities(entityBuilder.ConnectionString);
        }
    }
}
