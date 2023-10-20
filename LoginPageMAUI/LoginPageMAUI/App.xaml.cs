using LoginPageMAUI.Handlers;
using Microsoft.Maui.Platform;

namespace LoginPageMAUI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //Border less entry
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