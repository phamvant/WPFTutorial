using System.Windows;
using WPFTutorial.Store;
using WPFTutorial.ViewModels;

namespace WPFTutorial
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationStore.CurrentViewModel = new HomeViewModel();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel()
            };
            
            MainWindow.Show();

            base.OnStartup(e);
        }
    }

}
