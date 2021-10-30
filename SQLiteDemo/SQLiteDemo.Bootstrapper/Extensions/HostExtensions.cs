using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using SQLiteDemo.View;

namespace SQLiteDemo.Bootstrapper.Extensions
{
    public static class HostExtensions
    {

        public static IHostBuilder ConfigureWPFAppServices(this IHostBuilder builder) =>
            builder.ConfigureServices((context, services) =>
            {
                services.AddSingleton<MainWindow>();
            });

    }
}
