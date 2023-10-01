using MauiPages.Pages.ContentPages;
using MauiPages.Pages.FlyoutPages;
using MauiPages.Pages.NavigationPages;
using MauiPages.Pages.TabbedPages;

namespace MauiPages
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Content Page
            //MainPage = new ContentPageDemo1();

            //Navigation Page
            //var navigationPage = new NavigationPage(new NavigationPageDemo1());
            //navigationPage.BarBackgroundColor = Colors.Firebrick;
            //navigationPage.BarTextColor = Colors.LightGray;
            //MainPage = navigationPage;

            //FlyOut Page
            // MainPage = new FlyoutPageDemo();

            //Tabbed Page
            var tabbedPage = new TabbedPageDemo();
            tabbedPage.BarBackgroundColor = Colors.White;
            MainPage = tabbedPage;

        }
    }
}