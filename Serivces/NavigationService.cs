using WPFTutorial.Store;
using WPFTutorial.ViewModels;

namespace WPFTutorial.Serivces
{
    public class NavigationService<TViewModel>
        where TViewModel : BaseViewModel
    {
        private readonly Func<TViewModel> _createTViewModel;

        public NavigationService(Func<TViewModel> createTViewModel)
        {
            _createTViewModel = createTViewModel;
        }

        public void Navigate()
        {
            NavigationStore.CurrentViewModel = _createTViewModel();
        }

    }
}
