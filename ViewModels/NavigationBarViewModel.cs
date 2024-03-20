using System.Windows.Input;
using WPFTutorial.Commands;
using WPFTutorial.Serivces;
using WPFTutorial.Store;

namespace WPFTutorial.ViewModels
{
    public class NavigationBarViewModel : BaseViewModel
    {
        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateAccountCommand { get; }
        public ICommand NavigateLoginCommand { get; }

        public bool IsLoggedIn => !_accountStore.IsLoggedIn;

        public string Home = "Home";

        private AccountStore _accountStore;

        public NavigationBarViewModel (
            AccountStore accountStore,
            INavigationService<HomeViewModel> homeNavigationService, 
            INavigationService<AccountViewModel> accountNavigateService, 
            INavigationService<LoginViewModel> loginNavigateService)
        {
            _accountStore = accountStore;
            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(homeNavigationService);
            NavigateAccountCommand = new NavigateCommand<AccountViewModel>(accountNavigateService);
            NavigateLoginCommand = new NavigateCommand<LoginViewModel>(loginNavigateService);
        }
    }
}
