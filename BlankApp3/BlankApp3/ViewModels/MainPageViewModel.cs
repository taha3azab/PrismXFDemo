using Prism.Commands;
using Prism.Navigation;

namespace BlankApp3.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }

        public DelegateCommand OpenSecondPageCommand => new DelegateCommand(async () =>
        {
            await NavigationService.NavigateAsync("Second");
        });
        public DelegateCommand GoBackCommand => new DelegateCommand(async () =>
        {
            await NavigationService.GoBackAsync();
        });
    }
}
