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
        
        public NavigateCommand(Func<TViewModel> createViewModel)
        {
            _navigationService = new NavigationService<TViewModel>(createViewModel);
        }
        public override void Execute(object parameter)
        {
            _navigationService.Navigate();
        }
    }
}
