using System.Windows.Input;
using WPFTutorial.Store;
using WPFTutorial.Commands;

namespace WPFTutorial.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public ICommand NavigateLoginCommand { get; }

        public HomeViewModel() 
        {
            NavigateLoginCommand = new NavigateCommand<LoginViewModel>
                (new Serivces.NavigationService<LoginViewModel>(() => new LoginViewModel()));
        }
    }
}
