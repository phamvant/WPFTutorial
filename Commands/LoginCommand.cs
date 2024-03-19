
using WPFTutorial.Serivces;
using WPFTutorial.ViewModels;

namespace WPFTutorial.Commands
{
    public class LoginCommand : CommandBase
    {
        private readonly NavigationService<AccountViewModel> _navigationService;
        public LoginCommand()
        {
            _navigationService = new NavigationService<AccountViewModel>(() => new AccountViewModel());
        }
        public override void Execute(object parameter)
        {
            _navigationService.Navigate();
        }
    }
}
