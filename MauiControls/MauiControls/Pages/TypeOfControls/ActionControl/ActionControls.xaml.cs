namespace MauiControls.Pages.TypeOfControls.ActionControl;

public partial class ActionControls : ContentPage
{
	public ActionControls()
	{
		InitializeComponent();

	}

    private void demoClick_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("ReadLine Academy","You have clicked this button ","Ok", FlowDirection.LeftToRight);
    }
}