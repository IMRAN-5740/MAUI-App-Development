namespace MauiPages.Pages.ContentPages;

public partial class ContentPageDemo2 : ContentPage
{
	public ContentPageDemo2()
	{
		InitializeComponent();
	}

    private async void contentPageClose_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopModalAsync();
    }

    private async void contentPage3Demo_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new ContentPageDemo3());
    }
}