using System.Windows.Input;
using WPFTutorial.Commands;
using WPFTutorial.Store;

namespace WPFTutorial.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public string UserName { get; set;}
        public string Password { get; set;}

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new LoginCommand();
        }
    }
}
