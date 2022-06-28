using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CarbonCalculator.Pages.Dashboard;
using Microsoft.Toolkit.Mvvm.Input;

namespace CarbonCalculator.ViewModels
{
    public partial class LoginViewModel
    {
        #region Commands
        [ICommand]
        async void LogIn()
        {
            await Shell.Current.GoToAsync(nameof(HomePage));
        }
        #endregion
    }
}
