using SQLiteDemo.Model.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SQLiteDemo.DataAccess.Common.Interfaces
{
    public interface IUserRepository
    {

        Task<IEnumerable<IUserModel>> GetAllUsers();
        Task<bool> RemoveUser(IUserModel user);

    }
}
