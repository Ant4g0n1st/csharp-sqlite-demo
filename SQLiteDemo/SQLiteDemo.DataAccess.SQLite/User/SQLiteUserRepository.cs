using SQLiteDemo.DataAccess.Common.Interfaces;
using SQLiteDemo.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDemo.DataAccess.SQLite.User
{
    class SQLiteUserRepository : IUserRepository
    {
        public async Task<IEnumerable<IUserModel>> GetAllUsers()
        {
            var users = new List<UserModel>();
            return users;
        }
    }
}
