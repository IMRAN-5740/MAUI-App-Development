using MauiMVVMDemo.Pages;

namespace MauiMVVMDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(  new MainPageDemo());
        }
    }
}