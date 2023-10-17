namespace LocalhostMAUI
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
        }
        private async void callApiButton_Clicked(object sender, EventArgs e)
        {
            var httpClient=new HttpClient();
            var response = await httpClient.GetAsync("http://10.0.2.2:5149/WeatherForecast");
            var data = await response.Content.ReadAsStringAsync();
        }
    }
}