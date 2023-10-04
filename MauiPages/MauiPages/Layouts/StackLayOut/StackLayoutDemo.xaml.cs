using MauiPages.Layouts.AbsoluteLayOut;
using MauiPages.Layouts.FlexLayOut;
using MauiPages.Layouts.GridLayOut;

namespace MauiPages.Layouts.StackLayOut
{
    public partial class StackLayoutDemo : ContentPage
    {

        public StackLayoutDemo()
        {
            InitializeComponent();
        }

        private async void verticalSL_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TypesOfStackLayout.VerticalStackLayout());
        }

        private async void horizontalSL_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TypesOfStackLayout.HorizontalStackLayout());
        }

        private async void gridLayout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridLayoutDemo());
        }

        private async void absoluteLayout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AbsoluteLayoutDemo());
        }

        private async void flexLayout_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FlexLayoutDemo());
        }
    }
}