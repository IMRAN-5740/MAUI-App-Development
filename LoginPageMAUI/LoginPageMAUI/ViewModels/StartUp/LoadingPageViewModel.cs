using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginPageMAUI.Views.Dashboard;
using LoginPageMAUI.Views.StartUp;

namespace LoginPageMAUI.ViewModels.StartUp
{
    public class LoadingPageViewModel
    {
        public LoadingPageViewModel()
        {
            
        }
        private async void CheckUserLoginDetail()
        {

            string userDetailStr = Preferences.Get(nameof(App.UserDetails),"");
            if(string.IsNullOrWhiteSpace(userDetailStr))
            {
                //navigate to  Login Page
                await Shell.Current.GoToAsync(nameof(LoginPage));
            }
            else
            {
                //navigate to dashboard
                await Shell.Current.GoToAsync(nameof(DashboardPage));
            }
         }
    }
}
