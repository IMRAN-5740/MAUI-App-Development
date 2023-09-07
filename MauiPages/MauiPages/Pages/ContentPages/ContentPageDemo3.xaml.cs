namespace MauiPages.Pages.ContentPages;

public partial class ContentPageDemo3 : ContentPage
{
	public ContentPageDemo3()
	{
		InitializeComponent();
	}

    private async void contentPageClose_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopModalAsync();
    }
}