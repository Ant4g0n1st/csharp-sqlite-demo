using Microsoft.Extensions.Logging;
using SQLiteDemo.ViewModel.MainWindow;
using System;
using System.Windows;

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
            UserList.ItemsSource = await viewModel.GetAllUsers();
        }
    }
}
