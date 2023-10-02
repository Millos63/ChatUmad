using ChatUmad;
using ChatUmad.Controles;
using ChatUmad.Models;
using ChatUmad.Views.Dashboard;
using LoginFuncional.ViewModels;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUmad.ViewModels.Starup
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;

        #region Commands
        [ICommand]
        async void Login()
        {
            //await Shell.Current.GoToAsync($"//{nameof(DashboardPage)}");

            //if (!string.IsNullOrWhiteSpace(Email) && !string.IsNullOrWhiteSpace(Password))
            //{
            //    var userDetails = new UserBasicInfo();
            //    {
            //        userDetails.Email = Email;
            //        userDetails.FullName = "Test User Name";
            //    }

            //    if (Preferences.ContainsKey(nameof(App.UserDetails)))
            //    {
            //        Preferences.Remove(nameof(App.UserDetails));
            //    }

            //    string userDetailStr = JsonConvert.SerializeObject(userDetails);
            //    Preferences.Set(nameof(App.UserDetails), userDetailStr);
            //    App.UserDetails = userDetails;
            //    AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();
            //}
        }
        #endregion
    }
}
