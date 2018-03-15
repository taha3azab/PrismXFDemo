using Prism.Commands;
using Prism.Navigation;

namespace BlankApp3.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        public LoginPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }

        public DelegateCommand OpenMainPageCommand => new DelegateCommand(async () =>
        {
            // here is the trick
            // put '/' before page name token to set navigation stack to root
            await NavigationService.NavigateAsync("/Main");
        });

    }
}

/*
check prism release notes
https://github.com/PrismLibrary/Prism/releases


Remove pages from navigation stack

This feature allows you to remove pages form the navigation stack of a NavigationPage while at the same time navigating to 
a new page. For each page you wish to remove, prefix your navigation path with ../.

Example
Our app requires a user to login in order to edit "User" profile information. 
This will require the user to be prompted to login and then once successful continue to edit the profile. 
This leaves us with the following navigation stack:

"NavigationPage/UserList/UserDetails/LoginPage/EditUser"

If we were to hit the back button from the EditUser page, we would be returned to the LoginPage. This is not the desired experience. Instead, we want to go back to the UserDetails which was just updated. To achieve this we provide the following navigation URI from the LoginPage page with a successful login attempt.

NavigationService.NavigateAsync("../EditUser");

This would remove the LoginPage and then immediately navigate to the "EditUser" page which we now have access to.

You can chain the ../ instruction for each page that needs to be removed from the stack.

Given: "NavigationPage/ViewA/ViewB/ViewC/ViewD"
Navigate from ViewD with: NavigationService.NavigateAsync("../../../ViewE");
Results in: "NavigationPage/ViewA/ViewE"
 */
