namespace MauiLayouts.Layouts.StackLayouts;

public partial class StackLayoutDemo : ContentPage
{
	public StackLayoutDemo()
	{
		InitializeComponent();
	}

    private async void verticalStackLayoutButton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new VerticalStackLayoutDemo());
    }

    private  async void horizontalStackLayoutButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HorizontalStackLayoutDemo());
    }
}