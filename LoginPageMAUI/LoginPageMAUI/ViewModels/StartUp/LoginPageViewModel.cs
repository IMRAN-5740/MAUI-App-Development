using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LoginPageMAUI.Models;
using LoginPageMAUI.Views.Dashboard;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginPageMAUI.ViewModels.StartUp
{
    public partial class LoginPageViewModel:BaseViewModel
    {
        [ObservableProperty]
        private string _fullName;

        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _phoneNo;

        [ObservableProperty]
        private string _password;

        #region Commands
        [RelayCommand]
         async void Login()
        {

            if(string.IsNullOrWhiteSpace(Email) && string.IsNullOrWhiteSpace(Password) )
            {
                //Calling api
                var userDetails = new UserBasicInfo()
                {
                    FullName="Mohammad Imran",
                    Email=Email,
                    PhonoNo="01740380992",
                    Password=Password
                };
                if(Preferences.ContainsKey(nameof(App.UserDetails)))
                {
                    Preferences.Remove(nameof(App.UserDetails));
                }
                var userDetailsStr=JsonConvert.SerializeObject(userDetails);
                Preferences.Set(nameof(App.UserDetails), userDetailsStr);
                App.UserDetails = userDetails;
                await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");
            }
           
        }
        #endregion
    }
}
