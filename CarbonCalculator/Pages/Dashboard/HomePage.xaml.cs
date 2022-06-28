using CarbonCalculator.ViewModels;
using System.Diagnostics;

namespace CarbonCalculator.Pages.Dashboard;

public partial class HomePage : ContentPage
{
	//int count = 0;

	public Command HomeCommand { get; set; } = new Command(() =>
    {
		Debug.Write("Clicked");
    });

	public HomePage(HomeViewModel vm)
    {
        BindingContext = vm;
        InitializeComponent();
	}
}

