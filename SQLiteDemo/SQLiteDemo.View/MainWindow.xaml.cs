using Microsoft.Extensions.Logging;
using SQLiteDemo.Model.User;
using SQLiteDemo.ViewModel.MainWindow;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace SQLiteDemo.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ILogger<MainWindow> logger;
        private readonly IMainWindowViewModel viewModel;

        public MainWindow(ILogger<MainWindow> logger, IMainWindowViewModel viewModel)
        {
            this.logger = logger;
            this.viewModel = viewModel;
            InitializeComponent();
        }

        protected override async void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);
            logger.LogInformation("Fetching User List...");
            UserList.ItemsSource = await viewModel.GetAllUsers();
        }

        private void Border_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Border border = e.Source as Border;
            if (border != null)
            {
                border.Background = Brushes.LightCyan;
            }
        }

        private void Border_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Border border = e.Source as Border;
            if (border != null)
            {
                IUserModel user = border.DataContext as IUserModel;
                MessageBox.Show($"You selected user {user.FullName}");
            }
        }
    }
}
