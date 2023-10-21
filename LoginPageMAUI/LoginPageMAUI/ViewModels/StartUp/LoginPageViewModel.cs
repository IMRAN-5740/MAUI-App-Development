using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LoginPageMAUI.Models;
using LoginPageMAUI.Controls;

using LoginPageMAUI.Views.Dashboard;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginPageMAUI.Models.SD;

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

            if(!string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Password) )
            {
                //Calling api
                var userDetails = new UserBasicInfo();
                userDetails.Email = Email;
                userDetails.FullName = "Test UserName";
                userDetails.PhoneNo = PhoneNo;
                userDetails.Password = Password;
                if(Email.ToLower().Contains("student"))
                {
                    userDetails.RoleID = (int)RoleDetails.Student;
                    userDetails.RoleText = "Student Role";
                }
                else if (Email.ToLower().Contains("teacher"))
                {
                    userDetails.RoleID = (int)RoleDetails.Teacher;
                    userDetails.RoleText = "Teacher Role";
                }
                else
                {
                    userDetails.RoleID = (int)RoleDetails.Admin;
                    userDetails.RoleText = "Admin Role";
                }


                if(Preferences.ContainsKey(nameof(App.UserDetails)))
                {
                    Preferences.Remove(nameof(App.UserDetails));
                }
                var userDetailsStr=JsonConvert.SerializeObject(userDetails);
                Preferences.Set(nameof(App.UserDetails), userDetailsStr);
                App.UserDetails = userDetails;

                await AppConstant.AddFlyoutMenusDetails();
              

            }
           
        }
        #endregion
    }
}
