namespace MauiPages.Layouts.TypesOfLayout;

public partial class VerticalStackLayout : ContentPage
{
	public VerticalStackLayout()
	{
		InitializeComponent();
	}

    private  async void closeVSL_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    
}