using System.Windows.Input;
using WPFTutorial.Store;
using WPFTutorial.Commands;

namespace WPFTutorial.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public ICommand NavigateLoginCommand { get; }

        public HomeViewModel(NavigationStore navigationStore, AccountStore accountStore) 
        {
            NavigateLoginCommand = new NavigateCommand<LoginViewModel>
                (new Serivces.NavigationService<LoginViewModel>(navigationStore, () => new LoginViewModel(navigationStore, accountStore)));
        }
    }
}
