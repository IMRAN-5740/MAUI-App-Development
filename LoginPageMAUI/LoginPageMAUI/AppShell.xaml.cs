using LoginPageMAUI.Views.Dashboard;
using LoginPageMAUI.ViewModels;

namespace LoginPageMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            this.BindingContext = new AppShellViewModel();
            Routing.RegisterRoute(nameof(DashboardPage), typeof(DashboardPage));
        }
    }
}