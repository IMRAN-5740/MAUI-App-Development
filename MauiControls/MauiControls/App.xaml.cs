using MauiControls.Pages;
using MauiControls.Pages.TypeOfControls.CommonControl;

namespace MauiControls
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainControls());
        }
    }
}