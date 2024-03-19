using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
