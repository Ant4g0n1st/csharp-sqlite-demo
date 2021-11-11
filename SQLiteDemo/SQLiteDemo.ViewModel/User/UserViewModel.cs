using Microsoft.Toolkit.Mvvm.Input;
using SQLiteDemo.DataAccess.Common.Interfaces;
using SQLiteDemo.Model.User;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SQLiteDemo.ViewModel.User
{
    public class UserViewModel : IUserViewModel
    {

        private RelayCommand removeUserCommand;
        public ICommand RemoveUserCommand
        {
            get
            {
                if (removeUserCommand == null)
                {
                    removeUserCommand = new RelayCommand(async () => await RemoveUser());
                }
                return removeUserCommand;
            }
        }

        public string Name
        {
            get { return userModel.Name; }
            set
            {
                userModel.Name = value;
                OnPropertyChanged();
            }
        }
        public string LastName
        {
            get { return userModel.LastName; }
            set
            {
                userModel.LastName = value;
                OnPropertyChanged();
            }
        }

        public string FullName => userModel.FullName;

        public int ID
        {
            get { return userModel.ID; }
            set
            {
                userModel.ID = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private readonly IUserRepository userRepository;
        private readonly IUserModel userModel;

        public UserViewModel(IUserRepository userRepository, IUserModel userModel)
        {
            this.userRepository = userRepository;
            this.userModel = userModel;
        }

        private async Task RemoveUser()
        {
            await userRepository.RemoveUser(userModel);
        }
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void Dispose()
        {
        }
    }
}
