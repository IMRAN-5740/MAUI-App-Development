namespace SampleApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count+=10;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} times";
            else
                CounterBtn.Text = $"Congratulations ,I am a Dot Net Maui Developer{count} th";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}