namespace MauiControls.Pages.TypeOfControls.InputControl;

public partial class InputControls : ContentPage
{
	public InputControls()
	{
		InitializeComponent();
	}
    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
        pageTitleView.WidthRequest = width;
    }

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        sliderValue.Text=((int)e.NewValue).ToString();
    }

    private async void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        await DisplayAlert("ReadLine Academy", $"Stepper Value{e.NewValue}", "Ok");
    }
}