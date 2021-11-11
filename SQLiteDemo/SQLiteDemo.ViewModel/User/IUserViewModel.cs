using SQLiteDemo.Model.User;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace SQLiteDemo.ViewModel.User
{
    public interface IUserViewModel : IUserModel, INotifyPropertyChanged, IDisposable
    {
        ICommand RemoveUserCommand { get; }
    }
}
