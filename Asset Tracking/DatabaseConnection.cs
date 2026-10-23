using System.Configuration;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;

namespace Asset_Tracking
{
    public static class DatabaseConnection
    {
        // Username = Private Key
        // Password  = 4
        private const string Username = "mssql2401087";
        private const string Password = "pzjAQZ6zsU";

        public static dbEntities CreateContext()
        {
            // create a connection to the db
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
            // return a new instance of db
            /* NOTE TO SELF!
             * IF YOU HAVE REGENERATED THE DB MODEL AND HAVE 100 BUILD ERRORS
             * DELETE Model1.Designer.cs
             * 
             * Also probably add the connection string back to func def of dbEntities()
             */
            return new dbEntities(entityBuilder.ConnectionString);
        }
    }
}
