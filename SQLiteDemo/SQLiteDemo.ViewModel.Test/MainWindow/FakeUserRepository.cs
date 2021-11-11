using SQLiteDemo.DataAccess.Common.Events;
using SQLiteDemo.DataAccess.Common.Interfaces;
using SQLiteDemo.Model.User;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SQLiteDemo.ViewModel.Test.MainWindow
{
    class FakeUserRepository : IUserRepository
    {
        private List<IUserModel> users;

        public event EventHandler<UserModelEventArgs> UserRemoved;

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
            await Task.CompletedTask;
            return users;
        }

        public async Task RemoveUser(IUserModel user)
        {
            if (users.IndexOf(user) >= 0)
            {
                users.Remove(user);
            }
            await Task.CompletedTask;
        }
    }
}
