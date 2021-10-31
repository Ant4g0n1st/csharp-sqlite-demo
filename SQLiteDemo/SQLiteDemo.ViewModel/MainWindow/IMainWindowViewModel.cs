using SQLiteDemo.Model.User;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SQLiteDemo.ViewModel.MainWindow
{
    public interface IMainWindowViewModel
    {

        Task<IEnumerable<IUserModel>> GetAllUsers();

    }
}
