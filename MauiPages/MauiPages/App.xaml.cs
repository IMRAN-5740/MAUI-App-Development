using MauiPages.Pages.ContentPages;
using MauiPages.Pages.FlyoutPages;
using MauiPages.Pages.NavigationPages;

namespace MauiPages
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            // MainPage = new ContentPageDemo1();
            //var navigationPage = new NavigationPage( new NavigationPageDemo1());
            //navigationPage.BarBackgroundColor = Colors.Firebrick;
            //navigationPage.BarTextColor = Colors.LightGray;

            //MainPage = navigationPage;
            MainPage = new FlyoutPageDemo1();
        }
    }
}