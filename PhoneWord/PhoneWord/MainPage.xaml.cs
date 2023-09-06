﻿namespace PhoneWord
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        string translatedNumber;
        private void OnTranslate(object sender, EventArgs e)
        {
            string enteredNumber = PhoneNumberText.Text;
            translatedNumber = PhoneWord.PhonewordTranslator.ToNumber(enteredNumber);

            if (!string.IsNullOrEmpty(translatedNumber))
            {
                CallButton.IsEnabled = true;
                CallButton.Text = "Call " + translatedNumber;
            }
            else
            {
                CallButton.IsEnabled = false;
                CallButton.Text = "Call";
            }
        }
        async void OnCall(object sender, System.EventArgs e)
        {
            if (await this.DisplayAlert(
                "Dial a Number",
                "Would you like to call " + translatedNumber + "?",
                "Yes",
                "No"))
            {
                // TODO: dial the phone
            }
        }
    }
}