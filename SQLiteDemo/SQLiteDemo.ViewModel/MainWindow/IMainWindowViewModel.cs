using SQLiteDemo.ViewModel.User;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SQLiteDemo.ViewModel.MainWindow
{
    public interface IMainWindowViewModel : INotifyPropertyChanged, IDisposable
    {
        ObservableCollection<IUserViewModel> AllUsers { get; }

    }
}
