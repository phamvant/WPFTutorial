﻿using System.Windows.Input;
using WPFTutorial.Store;
using WPFTutorial.Commands;
using WPFTutorial.Serivces;

namespace WPFTutorial.ViewModels
{
    public class AccountViewModel : BaseViewModel
    {
        public ICommand NavigateHomeCommand { get; }

        public AccountViewModel(NavigationStore navigationStore)
        {
            NavigateHomeCommand = new NavigateCommand<HomeViewModel>
                (new NavigationService<HomeViewModel>(navigationStore, () => new HomeViewModel(navigationStore)));
        }
    }
}