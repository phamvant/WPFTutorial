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
            NavigationStore _navigationStore = new NavigationStore();

            _navigationStore.CurrentViewModel = new HomeViewModel(_navigationStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            
            MainWindow.Show();

            base.OnStartup(e);
        }
    }

}
