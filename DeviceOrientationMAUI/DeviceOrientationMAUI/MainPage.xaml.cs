namespace DeviceOrientationMAUI
{
    public partial class MainPage : ContentPage
    {
        
        private readonly DeviceOrientationService _deviceOrientationService;
        public MainPage()
        {
            InitializeComponent();
            DeviceDisplay.Current.MainDisplayInfoChanged += Current_MainDisplayInfoChanged;
            _deviceOrientationService = new DeviceOrientationService();
        }

        private void Current_MainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
        {
            Shell.Current.DisplayAlert("Orientation :",$"Current Orientation:{DeviceDisplay.Current.MainDisplayInfo.Orientation}", "Ok");

        }

        private void orientationBtn_Clicked(object sender, EventArgs e)
        {
            switch (DeviceDisplay.Current.MainDisplayInfo.Orientation)
            {
                case DisplayOrientation.Landscape: _deviceOrientationService.SetDeviceOrientation(DisplayOrientation.Portrait); break;
                case DisplayOrientation.Portrait: _deviceOrientationService.SetDeviceOrientation(DisplayOrientation.Landscape); break;
            }

            // Note: DeviceDisplay.Current.MainDisplayInfoChanged does not get fire when we change the orientation programatically
            // We can call the event handler method from here explicitely
        }
    }
}