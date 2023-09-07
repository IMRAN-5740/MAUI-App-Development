namespace MauiPages.Pages.ContentPages;

public partial class ContentPageDemo1 : ContentPage
{
	public ContentPageDemo1()
	{
		InitializeComponent();
	}

    private  async void contentPage2Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new ContentPageDemo2());
    }
}