using MauiControls.Pages.TypeOfControls.ActionControl;
using MauiControls.Pages.TypeOfControls.CommonControl;

namespace MauiControls.Pages;

public partial class MainControls : ContentPage
{
	public MainControls()
	{
		InitializeComponent();
	}

    private async void commonControl_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new CommonControls());
    }

    private async void actionControl_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ActionControls());
    }
}