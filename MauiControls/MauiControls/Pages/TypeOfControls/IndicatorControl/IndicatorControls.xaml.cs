using Microsoft.Maui.Controls;

namespace MauiControls.Pages.TypeOfControls.IndicatorControl;

public partial class IndicatorControls : ContentPage
{
	public IndicatorControls()
	{
		InitializeComponent();
	}

    private void activityIndicatorButton_Clicked(object sender, EventArgs e)
    {
       activityIndicator.IsRunning=!activityIndicator.IsRunning;
    }
}