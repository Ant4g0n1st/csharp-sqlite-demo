using SQLiteDemo.DataAccess.Common.Events;
using SQLiteDemo.Model.User;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SQLiteDemo.DataAccess.Common.Interfaces
{
    public interface IUserRepository
    {

        Task<IEnumerable<IUserModel>> GetAllUsers();

        event EventHandler<UserModelEventArgs> UserRemoved;
        Task RemoveUser(IUserModel user);

    }
}
