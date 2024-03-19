using System.Printing;
using WPFTutorial.Serivces;
using WPFTutorial.Store;
using WPFTutorial.ViewModels;

namespace WPFTutorial.Commands
{
    public class NavigateCommand<TViewModel> : CommandBase
        where TViewModel : BaseViewModel
    {
        private readonly NavigationService<TViewModel> _navigationService;
        
        public NavigateCommand(NavigationService<TViewModel> navigationService)
        {
            _navigationService = navigationService;
        }
        public override void Execute(object parameter)
        {
            _navigationService.Navigate();
        }
    }
}
