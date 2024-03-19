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

        public AccountViewModel(NavigationStore navigationStore, AccountStore accountStore)
        {
            Account = accountStore.CurrentAccount;

            NavigateHomeCommand = new NavigateCommand<HomeViewModel>
                (new NavigationService<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore, accountStore)));
        }
    }
}
