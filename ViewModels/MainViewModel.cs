
using WPFTutorial.Store;

namespace WPFTutorial.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public BaseViewModel CurrentViewModel => NavigationStore.CurrentViewModel;
        public MainViewModel()
        {
            NavigationStore.CurrentViewModelChanged += OnCurrentViewModelChange;
        }

        private void OnCurrentViewModelChange()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }
    }
}
