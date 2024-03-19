using System.Windows.Input;
using WPFTutorial.Store;
using WPFTutorial.Commands;

namespace WPFTutorial.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public ICommand NavigateLoginCommand { get; }

        public HomeViewModel(NavigationStore navigationStore) 
        {
            NavigateLoginCommand = new NavigateCommand<LoginViewModel>
                (new Serivces.NavigationService<LoginViewModel>(navigationStore, () => new LoginViewModel(navigationStore)));
        }
    }
}
