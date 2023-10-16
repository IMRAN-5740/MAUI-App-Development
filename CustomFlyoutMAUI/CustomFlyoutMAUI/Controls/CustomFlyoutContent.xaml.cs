namespace CustomFlyoutMAUI.Controls;

public partial class CustomFlyoutContent : ContentView
{
	public CustomFlyoutContent()
	{
		InitializeComponent();

	}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.DisplayAlert("Content Menu Clicked", "This item was tapped from the custom flyout content ", "Ok");
    }

   
}