using Microsoft.Extensions.Logging;
using SQLiteDemo.DataAccess.Common.Interfaces;
using SQLiteDemo.Model.User;
using System.Collections.Generic;
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
            IUserRepository userRepository) =>
            (this.logger, this.userRepository) = (logger, userRepository);
        public async Task<IEnumerable<IUserModel>> GetAllUsers()
        {
            logger.LogInformation("Getting all users from repository...");
            return await userRepository.GetAllUsers();
        }
    }
}
