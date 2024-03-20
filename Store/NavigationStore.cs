using WPFTutorial.ViewModels;

namespace WPFTutorial.Store
{
    public class NavigationStore
    {
        public event Action CurrentViewModelChanged = delegate { };

        private BaseViewModel? _currentViewModel;
        public BaseViewModel CurrentViewModel
        {
            get { return _currentViewModel; }
            set { _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
