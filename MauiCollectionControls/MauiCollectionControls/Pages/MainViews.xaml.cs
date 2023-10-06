namespace MauiCollectionControls.Pages;

public partial class MainViews : ContentPage
{
	public MainViews()
	{
		InitializeComponent();
	}

    private  async void carouselView_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CarouselViews());
    }

    private async void indicatorView_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new IndicatorViews());

    }

    private async void listView_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListViewDemo());
    }

    private async void collectionView_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CollectionViews());

    }
}