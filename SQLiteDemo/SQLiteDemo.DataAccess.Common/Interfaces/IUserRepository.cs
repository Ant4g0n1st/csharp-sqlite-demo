using SQLiteDemo.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDemo.DataAccess.Common.Interfaces
{
    public interface IUserRepository
    {

        Task<IEnumerable<IUserModel>> GetAllUsers();

    }
}
