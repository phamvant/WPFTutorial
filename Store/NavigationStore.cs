using WPFTutorial.ViewModels;

namespace WPFTutorial.Store
{
    public static class NavigationStore
    {
        public static event Action CurrentViewModelChanged;

        static private BaseViewModel _currentViewModel;
        static public BaseViewModel CurrentViewModel
        {
            get { return _currentViewModel; }
            set { _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        static private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
