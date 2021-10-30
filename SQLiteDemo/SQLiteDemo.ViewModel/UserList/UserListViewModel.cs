using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SQLiteDemo.DataAccess.Common.Interfaces;
using SQLiteDemo.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDemo.ViewModel.UserList
{
    public class UserListViewModel : IUserListViewModel
    {
        private readonly ILogger<UserListViewModel> logger;
        private readonly IServiceProvider services;

        public UserListViewModel(ILogger<UserListViewModel> logger, IServiceProvider services) =>
            (this.logger, this.services) = (logger, services);
        public async Task<IEnumerable<IUserModel>> GetAllUsers()
        {
            IEnumerable<IUserModel> users;
            using (IServiceScope scope = services.CreateScope())
            {
                IServiceProvider serviceProvider = scope.ServiceProvider;
                users = await serviceProvider.GetRequiredService<IUserRepository>().GetAllUsers();
            }
            return users;
        }
    }
}
