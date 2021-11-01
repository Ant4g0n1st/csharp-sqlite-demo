using Microsoft.Extensions.Logging;
using SQLiteDemo.DataAccess.Common.Interfaces;
using SQLiteDemo.Model.User;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace SQLiteDemo.DataAccess.SQLite.User
{
    public class SqliteUserRepository : IUserRepository
    {
        private ILogger<SqliteUserRepository> logger;

        public SqliteUserRepository(ILogger<SqliteUserRepository> logger) => this.logger = logger;

        public async Task<IEnumerable<IUserModel>> GetAllUsers()
        {
            logger.LogInformation("Getting all users from the database...");
            List<IUserModel> users = new List<IUserModel>();
            using (var connection = new SQLiteConnection(GetConnectionString()))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "select * from Users";
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var user = new UserModel
                        {
                            Name = reader["Name"].ToString(),
                            LastName = reader["LastName"].ToString(),
                        };
                        users.Add(user);
                        logger.LogInformation($"User found : {user}");
                    }
                }
            }
            return users;
        }

        private static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["SQLite-Users"].ConnectionString;
        }
    }
}
