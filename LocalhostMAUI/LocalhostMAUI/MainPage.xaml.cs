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
          //https://localhost:7209/WeatherForecast
          //http://localhost:5149/WeatherForecast

            var httpClient =new HttpClient();
            var baseUrl = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5149" : "http://localhost:5149";
            
            //Here data not loaded sir from weather forcast .
            //Please resolve it sir
            var response =await  httpClient.GetAsync($"{baseUrl}/WeatherForecast");
            var data = await response.Content.ReadAsStringAsync();
        }
    }
}