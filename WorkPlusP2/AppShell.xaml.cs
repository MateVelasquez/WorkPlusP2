using WorkPlusP2.Views.Dashboard;

namespace WorkPlusP2;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(Views.Dashboard.DashboardPage),typeof(Views.Dashboard.DashboardPage));
	}
}
