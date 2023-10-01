namespace MauiPages.Layouts;

public partial class StackLayoutDemo : ContentPage
{

	public StackLayoutDemo()
	{
		InitializeComponent();
	}

    private async void verticalSL_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TypesOfLayout.VerticalStackLayout());
    }

    private async void horizontalSL_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TypesOfLayout.HorizontalStackLayout());
    }

    private async void gridLayout_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GridLayoutDemo());
    }
}