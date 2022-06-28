using System.Windows.Input;
using CarbonCalculator.ViewModels;

namespace CarbonCalculator.Pages.Startup;

public partial class LoginPage : ContentPage
{
    public LoginPage(LoginViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
    }
}