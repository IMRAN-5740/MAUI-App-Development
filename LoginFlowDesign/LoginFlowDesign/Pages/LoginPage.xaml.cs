using LoginFlowDesign.Services;

namespace LoginFlowDesign.Pages;

public partial class LoginPage : ContentPage
{
    private readonly AuthService _authService;

    public LoginPage(AuthService authService)
	{
		InitializeComponent();
        _authService = authService;
    }

    private async    void loginButton_Clicked(object sender, EventArgs e)
    {
        _authService.Login();
        await Shell.Current.GoToAsync($"//{nameof(MainPage)}");

    }
}