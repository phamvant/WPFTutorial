using System.Windows.Input;
using WPFTutorial.Commands;
using WPFTutorial.Models;
using WPFTutorial.Store;

namespace WPFTutorial.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _username;

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel(NavigationStore navigationStore, AccountStore accountStore)
        {
            LoginCommand = new LoginCommand(accountStore, new Serivces.NavigationService<AccountViewModel>
                (navigationStore, () => new AccountViewModel(navigationStore, accountStore)), this);
        }
    }
}
