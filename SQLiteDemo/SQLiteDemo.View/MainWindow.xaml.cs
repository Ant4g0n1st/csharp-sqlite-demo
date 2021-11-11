using SQLiteDemo.ViewModel.MainWindow;
using System.Windows;

namespace SQLiteDemo.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IMainWindowViewModel viewModel;

        public MainWindow(IMainWindowViewModel viewModel)
        {
            this.viewModel = viewModel;
            InitializeComponent();
            DataContext = this.viewModel;
        }
    }
}
