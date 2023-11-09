using LoginFlowDesign.Pages;

namespace LoginFlowDesign
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(LogoutPage), typeof(LogoutPage));
            Routing.RegisterRoute(nameof(ListingPage),typeof(ListingPage));
            Routing.RegisterRoute(nameof(LoadingPage), typeof(LoadingPage));
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
        }
    }
}