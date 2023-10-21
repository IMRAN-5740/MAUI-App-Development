using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginPageMAUI.Views.Dashboard;
using LoginPageMAUI.Controls;

using LoginPageMAUI.Views.StartUp;
using Newtonsoft.Json;
using LoginPageMAUI.Models;
using LoginPageMAUI.Models.SD;

namespace LoginPageMAUI.ViewModels.StartUp
{
    public class LoadingPageViewModel
    {
        public LoadingPageViewModel()
        {
            CheckUserLoginDetail();
        }
        private async void CheckUserLoginDetail()
        {

            string userDetailStr = Preferences.Get(nameof(App.UserDetails),"");
            if(string.IsNullOrWhiteSpace(userDetailStr))
            {
                //navigate to  Login Page
                await Shell.Current.GoToAsync($"//{ nameof(LoginPage)}");
            }
            else
            {
                //navigate to dashboard
                var userInfo=JsonConvert.DeserializeObject<UserBasicInfo>(userDetailStr);
                App.UserDetails=userInfo;


              await AppConstant.AddFlyoutMenusDetails();

               
            }
        }
    }
}
