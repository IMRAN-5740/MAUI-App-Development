namespace MauiControls.Pages.TypeOfControls.ActionControl;

public partial class ActionControls : ContentPage
{
	public ActionControls()
	{
		InitializeComponent();

	}

    private void demoButton_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("ReadLine Academy","You have clicked this button ","Ok", FlowDirection.LeftToRight);
    }

    private void demoImageButton_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("ReadLine Academy", "You have clicked the Download button ", "Ok", FlowDirection.LeftToRight);

    }

    private void searchButton_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("ReadLine Academy", $"You have search  {searchButton.Text}", "Ok", FlowDirection.LeftToRight);

    }

    private void facebookSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("ReadLine Academy", "You have Clicked  Facebook Link", "Ok", FlowDirection.LeftToRight);

    }

    private void instagramSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("ReadLine Academy", "You have Clicked  Instagram Link", "Ok", FlowDirection.LeftToRight);

    }

    private void twitterSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("ReadLine Academy", "You have Clicked  Twitter Link", "Ok", FlowDirection.LeftToRight);

    }

    private void gmailSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("ReadLine Academy", "You have Clicked  Gmail Link", "Ok", FlowDirection.LeftToRight);

    }
}