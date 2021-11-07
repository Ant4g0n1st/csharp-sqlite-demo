using Microsoft.Extensions.Logging;
using SQLiteDemo.DataAccess.Common.Interfaces;
using SQLiteDemo.Model.User;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace SQLiteDemo.ViewModel.MainWindow
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        private readonly ILogger<MainWindowViewModel> logger;
        private readonly IUserRepository userRepository;

        private ObservableCollection<IUserModel> users;

        public MainWindowViewModel(
            ILogger<MainWindowViewModel> logger,
            IUserRepository userRepository) =>
            (this.logger, this.userRepository) = (logger, userRepository);

        public async Task<bool> RemoveUser(IUserModel user)
        {
            bool removed = await userRepository.RemoveUser(user);
            if (removed)
            {
                users.Remove(user);
            }
            return removed;
        }

        public async Task<ObservableCollection<IUserModel>> GetAllUsers()
        {
            logger.LogInformation("Getting all users from repository...");
            return users = new ObservableCollection<IUserModel>(await userRepository.GetAllUsers());
        }
    }
}
