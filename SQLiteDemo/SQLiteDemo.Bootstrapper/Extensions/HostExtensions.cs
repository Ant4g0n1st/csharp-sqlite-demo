using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SQLiteDemo.View;
using SQLiteDemo.DataAccess.Common.Interfaces;
using SQLiteDemo.DataAccess.SQLite.User;
using SQLiteDemo.ViewModel.MainWindow;

namespace SQLiteDemo.Bootstrapper.Extensions
{
    public static class HostExtensions
    {

        public static IHostBuilder ConfigureWPFAppServices(this IHostBuilder builder) =>
            builder.ConfigureServices((context, services) =>
            {
                services.AddScoped<IMainWindowViewModel, MainWindowViewModel>();
                services.AddScoped<IUserRepository, SqliteUserRepository>();
                services.AddSingleton<MainWindow>();
            });

    }
}
