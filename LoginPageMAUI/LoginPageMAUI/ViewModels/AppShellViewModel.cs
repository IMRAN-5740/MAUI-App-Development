using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using LoginPageMAUI.Views.StartUp;

namespace LoginPageMAUI.ViewModels
{
    public partial class AppShellViewModel:BaseViewModel
    {
        [RelayCommand]
          async void SignOut()
        {

            if (Preferences.ContainsKey(nameof(App.UserDetails)))
            {
                Preferences.Remove(nameof(App.UserDetails));
            }
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
