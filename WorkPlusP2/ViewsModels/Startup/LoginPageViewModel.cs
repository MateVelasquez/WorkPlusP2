using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkPlusP2.Views.Dashboard;

namespace WorkPlusP2.ViewsModels.Startup
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ICommand]
        async void Login()
        {
            await Shell.Current.GoToAsync($"//{nameof(Views.Dashboard.DashboardPage)}");
        }

    }
}
