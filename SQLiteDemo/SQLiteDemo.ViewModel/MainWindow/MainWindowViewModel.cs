using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SQLiteDemo.DataAccess.Common.Interfaces;
using SQLiteDemo.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLiteDemo.ViewModel.MainWindow
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        private readonly ILogger<MainWindowViewModel> logger;
        private readonly IUserRepository userRepository;
        private readonly IMainWindowViewModel viewModel;

        public MainWindowViewModel(
            ILogger<MainWindowViewModel> logger,
            IUserRepository userRepository,
            IMainWindowViewModel viewModel) =>
            (this.logger, this.userRepository, this.viewModel) = (logger, userRepository, viewModel);
        public async Task<IEnumerable<IUserModel>> GetAllUsers()
        {
            logger.LogInformation("Getting all users from repository...");
            return await userRepository.GetAllUsers();
        }
    }
}
