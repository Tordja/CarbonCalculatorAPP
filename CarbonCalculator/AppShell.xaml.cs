using CarbonCalculator.Pages.Dashboard;

namespace CarbonCalculator;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
    }
}
