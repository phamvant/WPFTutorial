using System.Windows.Input;
using WPFTutorial.Store;
using WPFTutorial.Commands;
using WPFTutorial.Serivces;
using WPFTutorial.Models;

namespace WPFTutorial.ViewModels
{
    public class AccountViewModel : BaseViewModel
    {
        public ICommand NavigateHomeCommand { get; }

        public Account Account { get; set; } = new Account();

        public NavigationBarViewModel NavigationBarViewModel { get; }

        public AccountViewModel(AccountStore accountStore, NavigationBarViewModel navigationBarViewModel, NavigationService<HomeViewModel> navigateHomeService)
        {
            Account = accountStore.CurrentAccount;
            NavigationBarViewModel = navigationBarViewModel;

            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(navigateHomeService);
        }
    }
}
