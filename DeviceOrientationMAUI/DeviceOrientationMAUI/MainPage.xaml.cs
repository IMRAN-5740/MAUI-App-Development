namespace DeviceOrientationMAUI
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            DeviceDisplay.Current.MainDisplayInfoChanged += Current_MainDisplayInfoChanged;
        }

        private void Current_MainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
        {
            Shell.Current.DisplayAlert("Orientation :",$"Current Orientation:{DeviceDisplay.Current.MainDisplayInfo.Orientation}", "Ok");

        }

        private void OnCounterClicked(object sender,  EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
            Shell.Current.DisplayAlert("Orientation :", DeviceDisplay.Current.MainDisplayInfo.Orientation.ToString(), "Ok");

        }
    }
}