using WPFTutorial.Models;

namespace WPFTutorial.Store
{
    public class AccountStore
    {
        private Account _currentAccount = new Account();

        public Account CurrentAccount
        {
            get { return _currentAccount; }
            set
            {
                _currentAccount = value;
            }
        }
    }
}
