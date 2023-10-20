using LoginPageMAUI.Handlers;
using LoginPageMAUI.Models;
using Microsoft.Maui.Platform;

namespace LoginPageMAUI
{
    public partial class App : Application
    {
        public static UserBasicInfo UserDetails;
        public App()
        {
            InitializeComponent();
            //BorderLess Entry
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BorderLessEntry), (handler, view) =>
            {
                if (view is BorderLessEntry)
                {
#if __ANDROID__
                    handler.PlatformView.SetBackgroundColor(Colors.Transparent.ToPlatform());
#elif __IOS__
                handler.PlatformView.BorderStyle = UIKit.UITextBorderStyle.None;
#endif
                }
            });
           
           MainPage = new AppShell();
        }
    }
}