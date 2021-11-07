using SQLiteDemo.Model.User;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace SQLiteDemo.ViewModel.MainWindow
{
    public interface IMainWindowViewModel
    {

        Task<ObservableCollection<IUserModel>> GetUsers();

        Task PopulateUsers();

        Task<bool> RemoveUser(IUserModel user);

    }
}
