using Microsoft.Extensions.Logging;
using SQLiteDemo.DataAccess.Common.Events;
using SQLiteDemo.DataAccess.Common.Interfaces;
using SQLiteDemo.ViewModel.User;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace SQLiteDemo.ViewModel.MainWindow
{
    public class MainWindowViewModel : IMainWindowViewModel
    {
        private readonly ILogger<MainWindowViewModel> logger;
        private readonly IUserRepository userRepository;

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<IUserViewModel> AllUsers { get; private set; }

        public MainWindowViewModel(ILogger<MainWindowViewModel> logger, IUserRepository userRepository)
        {
            this.logger = logger;
            this.userRepository = userRepository;
            InitializeViewModel();
        }

        private async void InitializeViewModel()
        {
            AllUsers = new ObservableCollection<IUserViewModel>();
            var users = await userRepository.GetAllUsers();
            foreach (var user in users)
            {
                AllUsers.Add(new UserViewModel(userRepository, user));
            }
            userRepository.UserRemoved += OnUserRemoved;
        }

        protected virtual void OnUserRemoved(object source, UserModelEventArgs args)
        {
            AllUsers.Remove(AllUsers.First(user => user.ID == args.User.ID));
        }

        public void Dispose()
        {
            userRepository.UserRemoved -= OnUserRemoved;
        }
    }
}
