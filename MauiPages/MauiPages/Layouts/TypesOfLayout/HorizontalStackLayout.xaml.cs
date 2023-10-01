namespace MauiPages.Layouts.TypesOfLayout;

public partial class HorizontalStackLayout : ContentPage
{
	public HorizontalStackLayout()
	{
		InitializeComponent();
	}

    private async void closeVSL_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}