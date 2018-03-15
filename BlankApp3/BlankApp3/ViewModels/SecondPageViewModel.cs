
using Prism.Commands;
using Prism.Navigation;

namespace BlankApp3.ViewModels
{
    public class SecondPageViewModel : ViewModelBase
    {
        public SecondPageViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        public DelegateCommand GoBackCommand => new DelegateCommand(async () =>
        {
            await NavigationService.GoBackAsync();
        });
        
    }
}
