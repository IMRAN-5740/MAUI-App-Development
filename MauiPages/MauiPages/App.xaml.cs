using MauiPages.Pages.ContentPages;

namespace MauiPages
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ContentPageDemo1();
        }
    }
}