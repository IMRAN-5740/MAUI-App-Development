namespace MauiPages.Layouts.GridLayOut;

public partial class GridLayoutDemo : ContentPage
{
    public GridLayoutDemo()
    {
        InitializeComponent();
    }

    private async void closeGrid_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}