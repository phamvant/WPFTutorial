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

        public NavigationBarViewModel (
            NavigationService<HomeViewModel> homeNavigationService, 
            NavigationService<AccountViewModel> accountNavigateService, 
            NavigationService<LoginViewModel> loginNavigateService)
        {
            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(homeNavigationService);
            NavigateAccountCommand = new NavigateCommand<AccountViewModel>(accountNavigateService);
            NavigateLoginCommand = new NavigateCommand<LoginViewModel>(loginNavigateService);
        }
    }
}
