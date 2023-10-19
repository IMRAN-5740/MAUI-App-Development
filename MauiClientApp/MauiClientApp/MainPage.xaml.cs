namespace MauiClientApp
{
    public partial class MainPage : ContentPage
    {
        private readonly HttpClient _httpClient = new();
        private const string BaseAddress = "https://9k6bw3ps-5149.asse.devtunnels.ms";

        public MainPage()
        {
            InitializeComponent();
        }

        private async void callApiButton(object sender, EventArgs e)
        {
            var jSonResult = await _httpClient.GetStringAsync($"{BaseAddress}/WeatherForecast/");
            weatherResult.Text=jSonResult;
        }
    }
}