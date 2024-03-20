using WPFTutorial.Serivces;
using WPFTutorial.ViewModels;

namespace WPFTutorial.Commands
{
    public class NavigateCommand<TViewModel> : CommandBase
        where TViewModel : BaseViewModel
    {
        private readonly INavigationService<TViewModel> _navigationService;
        
        public NavigateCommand(INavigationService<TViewModel> navigationService)
        {
            _navigationService = navigationService;
        }
        public override void Execute(object parameter)
        {
            _navigationService.Navigate();
        }
    }
}
