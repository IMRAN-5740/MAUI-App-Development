using LoginPageMAUI.ViewModels.StartUp;

namespace LoginPageMAUI.Views.StartUp;

public partial class LoadingPage : ContentPage
{
	public LoadingPage(LoadingPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}