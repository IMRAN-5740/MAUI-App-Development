using LoginFlowDesign.Services;

namespace LoginFlowDesign.Pages;

public partial class LoadingPage : ContentPage
{
    private readonly AuthService _authService;

    public LoadingPage(AuthService authService)
	{
		InitializeComponent();
        _authService = authService;
    }
    protected override async void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

        if(await _authService.IsAuthenticatedAsync())
        {
            //User is Logged in 
            //redirected to main page
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");

        }
        else
        {
            //User is not logged in 
            //redirected to login page
          await  Shell.Current.GoToAsync($"//{nameof(LoginPage)}");

        }
    }


}