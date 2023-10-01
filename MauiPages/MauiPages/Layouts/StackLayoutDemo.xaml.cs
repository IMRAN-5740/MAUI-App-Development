namespace MauiPages.Layouts;

public partial class StackLayoutDemo : ContentPage
{

	public StackLayoutDemo()
	{
		InitializeComponent();
	}

    private async void verticalSL_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new TypesOfLayout.VerticalStackLayout());
    }

    private async void horizontalSL_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new TypesOfLayout.HorizontalStackLayout());
    }
}