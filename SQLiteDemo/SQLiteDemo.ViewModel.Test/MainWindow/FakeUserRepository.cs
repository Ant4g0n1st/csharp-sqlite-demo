using SQLiteDemo.DataAccess.Common.Interfaces;
using SQLiteDemo.Model.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SQLiteDemo.ViewModel.Test.MainWindow
{
    class FakeUserRepository : IUserRepository
    {
        private List<IUserModel> users;

        public FakeUserRepository()
        {
            Initialize();
        }

        private void Initialize()
        {
            users = new List<IUserModel>{
                new UserModel{
                   Name = "First",
                   LastName = "User",
                   ID = 1,
                },
                new UserModel{
                   Name = "Second",
                   LastName = "User",
                   ID = 2,
                },
                new UserModel{
                   Name = "Third",
                   LastName = "User",
                   ID = 3,
                },
            };
        }

        public async Task<IEnumerable<IUserModel>> GetAllUsers()
        {
            return users;
        }

        public async Task<bool> RemoveUser(IUserModel user)
        {
            if (users.IndexOf(user) >= 0)
            {
                users.Remove(user);
                return true;
            }
            return false;
        }
    }
}
