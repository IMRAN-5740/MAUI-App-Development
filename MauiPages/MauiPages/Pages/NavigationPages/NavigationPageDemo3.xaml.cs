namespace MauiPages.Pages.NavigationPages;

public partial class NavigationPageDemo3 : ContentPage
{
	public NavigationPageDemo3()
	{
		InitializeComponent();
	}

    private async void navigationPageClose_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}