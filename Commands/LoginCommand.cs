
using System.Windows;
using WPFTutorial.Models;
using WPFTutorial.Serivces;
using WPFTutorial.Store;
using WPFTutorial.ViewModels;

namespace WPFTutorial.Commands
{
    public class LoginCommand : CommandBase
    {
        private readonly INavigationService<AccountViewModel> _navigationService;

        private readonly LoginViewModel _loginViewModel;

        private AccountStore _accountStore;
        public LoginCommand(AccountStore accountStore, INavigationService<AccountViewModel> navigationService, LoginViewModel loginViewModel)
        {
            _navigationService = navigationService;
            _loginViewModel = loginViewModel;
            _accountStore = accountStore;
        }
        public override void Execute(object parameter)
        {
            _accountStore.CurrentAccount = new Account();
            _accountStore.CurrentAccount.username = _loginViewModel.Username;
            _accountStore.CurrentAccount.email = _loginViewModel.Email;

            _navigationService.Navigate();
        }
    }
}
