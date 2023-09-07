namespace MauiPages.Pages.NavigationPages;

public partial class NavigationPageDemo1 : ContentPage
{
	public NavigationPageDemo1()
	{
		InitializeComponent();
	}

    private async void navigationPage2Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new NavigationPageDemo2());
    }
}