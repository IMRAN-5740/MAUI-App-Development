namespace MauiPages.Pages.NavigationPages;

public partial class NavigationPageDemo2 : ContentPage
{
	public NavigationPageDemo2()
	{
		InitializeComponent();
	}

   
    private async void navigationPage3Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavigationPageDemo3());

    }
    private async void navigationPageClose_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}