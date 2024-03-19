using System.Windows;
using WPFTutorial.Models;
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

            AccountStore accountStore = new AccountStore();

            _navigationStore.CurrentViewModel = new HomeViewModel(_navigationStore, accountStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            
            MainWindow.Show();

            base.OnStartup(e);
        }
    }

}
