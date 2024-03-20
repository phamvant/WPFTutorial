using System.Windows;
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

        private readonly Func<NavigationBarViewModel> _navigationBarViewModel;

        public App()
        {
            _navigationStore = new NavigationStore();
            _accountStore = new AccountStore();
            _navigationBarViewModel = createNavigationBar();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            INavigationService<HomeViewModel> navigationHomeService = createNavigateHomeService();

            navigationHomeService.Navigate();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore)
            };
            
            MainWindow.Show();

            base.OnStartup(e);
        }

        public INavigationService<HomeViewModel> createNavigateHomeService()
        {
            return new LayoutNavigationService<HomeViewModel>(_navigationStore, () => new HomeViewModel(createNavigateLoginService()), createNavigationBar());
        }
        public INavigationService<AccountViewModel> createNavigateAccountService()
        {
            return new LayoutNavigationService<AccountViewModel>(_navigationStore, () => new AccountViewModel(_accountStore, createNavigateHomeService()), createNavigationBar());
        }

        public INavigationService<LoginViewModel> createNavigateLoginService()
        {
            return new NavigationService<LoginViewModel>(_navigationStore, () => new LoginViewModel(_accountStore, createNavigateAccountService()));
        }

        public Func<NavigationBarViewModel> createNavigationBar()
        {
            return () => new NavigationBarViewModel(
                _accountStore,
                createNavigateHomeService(),
                createNavigateAccountService(),
                createNavigateLoginService());
        }
    }
}
