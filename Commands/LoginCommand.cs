
using System.Windows;
using WPFTutorial.Serivces;
using WPFTutorial.Store;
using WPFTutorial.ViewModels;

namespace WPFTutorial.Commands
{
    public class LoginCommand : CommandBase
    {
        private readonly NavigationService<AccountViewModel> _navigationService;
        public LoginCommand(NavigationService<AccountViewModel> navigationService) 
        {
            _navigationService = navigationService;
        }
        public override void Execute(object parameter)
        {
            _navigationService.Navigate();
        }
    }
}
