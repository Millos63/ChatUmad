using ChatUmad;
using ChatUmad.Views.Startup;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatUmad.ViewModels
{
    public partial class AppShellViewModel : BaseViewModel
    {
        [ICommand]
        async void SignOut()
        {
            //if (Preferences.ContainsKey(nameof(App.UserDetails)))
            //{
            //    Preferences.Remove(nameof(App.UserDetails));
            //}
            //await Shell.Current.GoToAsync($"//{nameof(Login)}");
        }
    }
}