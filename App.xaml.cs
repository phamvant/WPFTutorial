using System.Windows;
using WPFTutorial.Models;
using WPFTutorial.Serivces;
using WPFTutorial.Store;
using WPFTutorial.ViewModels;

namespace WPFTutorial
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore;

        private readonly AccountStore _accountStore;

        private readonly NavigationBarViewModel _navigationBarViewModel;

        public App()
        {
            _navigationStore = new NavigationStore();
            _accountStore = new AccountStore();
            _navigationBarViewModel = new NavigationBarViewModel(
                createNavigateHomeService(),
                createNavigateAccountService(),
                createNavigateLoginService());
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationService<HomeViewModel> navigationHomeService = createNavigateHomeService();

            navigationHomeService.Navigate();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            
            MainWindow.Show();

            base.OnStartup(e);
        }

        public NavigationService<HomeViewModel> createNavigateHomeService()
        {
            return new NavigationService<HomeViewModel>(_navigationStore, () => new HomeViewModel(_navigationBarViewModel, createNavigateLoginService()));
        }
        public NavigationService<AccountViewModel> createNavigateAccountService()
        {
            return new NavigationService<AccountViewModel>(_navigationStore, () => new AccountViewModel(_accountStore, _navigationBarViewModel, createNavigateHomeService()));
        }

        public NavigationService<LoginViewModel> createNavigateLoginService()
        {
            return new NavigationService<LoginViewModel>(_navigationStore, () => new LoginViewModel(_accountStore, createNavigateAccountService()));
        }
    }
}
