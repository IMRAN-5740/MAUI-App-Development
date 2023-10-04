namespace MauiPages.Layouts.TypesOfStackLayout;

public partial class VerticalStackLayout : ContentPage
{
    public VerticalStackLayout()
    {
        InitializeComponent();
    }

    private async void closeVSL_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }


}