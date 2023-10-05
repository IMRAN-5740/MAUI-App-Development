using MauiControls.Pages.TypeOfControls.ActionControl;
using MauiControls.Pages.TypeOfControls.CommonControl;
using MauiControls.Pages.TypeOfControls.IndicatorControl;
using MauiControls.Pages.TypeOfControls.InputControl;

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
    private async void inputControl_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new InputControls());
    }

    private async void indicatorControl_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new IndicatorControls());
    }
}