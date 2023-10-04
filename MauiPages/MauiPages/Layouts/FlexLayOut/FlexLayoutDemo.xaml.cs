namespace MauiPages.Layouts.FlexLayOut;

public partial class FlexLayoutDemo : ContentPage
{
	public FlexLayoutDemo()
	{
		InitializeComponent();
	}
    protected override void OnSizeAllocated(double width, double height)
    {
        base.OnSizeAllocated(width, height);
        pageTitleView.WidthRequest = width;
    }
}