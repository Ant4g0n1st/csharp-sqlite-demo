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
            await viewModel.PopulateUsers();
            UserList.ItemsSource = await viewModel.GetUsers();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = e.Source as Button;
            if (button != null)
            {
                IUserModel user = button.DataContext as IUserModel;
                MessageBoxResult result = MessageBox.Show(
                    $"Remove {user.FullName}?",
                    "Please Confirm",
                    MessageBoxButton.YesNo);
                if (result.Equals(MessageBoxResult.Yes))
                {
                    viewModel.RemoveUser(user);
                }
                e.Handled = true;
            }
        }

        private void Button_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            Button button = e.Source as Button;
            if (button != null)
            {
                button.Background = Brushes.LightGray;
                e.Handled = true;
            }
        }
    }
}
