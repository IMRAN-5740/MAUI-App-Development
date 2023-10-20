using LoginPageMAUI.ViewModels.StartUp;

namespace LoginPageMAUI.Views.StartUp;

public partial class LoginPage : ContentPage
{
	public LoginPage( LoginPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;

	}
}