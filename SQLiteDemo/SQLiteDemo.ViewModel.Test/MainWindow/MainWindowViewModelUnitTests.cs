using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SQLiteDemo.DataAccess.Common.Interfaces;
using SQLiteDemo.ViewModel.MainWindow;
using SQLiteDemo.ViewModel.Test.Util;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SQLiteDemo.ViewModel.Test.MainWindow
{
    [TestClass]
    public class MainWindowViewModelUnitTests
    {
        [TestMethod]
        public async Task MainWindowViewModel_GetAllUsers_ReturnsListWith3Items()
        {
            // Arrange
            var host = GenericHostUtilities.CreateBuilderWithFakeLogging()
                .ConfigureServices(services =>
                    services.AddScoped<IUserRepository, FakeUserRepository>()
                            .AddSingleton<IMainWindowViewModel, MainWindowViewModel>())
                .Build();

            var viewModel = host.Services.GetRequiredService<IMainWindowViewModel>();

            // Act
            await viewModel.PopulateUsers();
            var users = await viewModel.GetUsers();

            // Assert
            Assert.IsTrue(users.Count == 3);
        }

        [TestMethod]
        public async Task MainWindowViewModel_GetAllUsers_UserCountIs2AfterRemoveUserSucceeds()
        {
            // Arrange
            var host = GenericHostUtilities.CreateBuilderWithFakeLogging()
                .ConfigureServices(services =>
                    services.AddScoped<IUserRepository, FakeUserRepository>()
                            .AddSingleton<IMainWindowViewModel, MainWindowViewModel>())
                .Build();

            var viewModel = host.Services.GetRequiredService<IMainWindowViewModel>();

            // Act
            await viewModel.PopulateUsers();
            var users = await viewModel.GetUsers();
            var user = users.First();
            var result = await viewModel.RemoveUser(user);

            // Assert
            Assert.IsTrue(result);
            Assert.IsTrue(users.Count == 2);
        }
    }
}
