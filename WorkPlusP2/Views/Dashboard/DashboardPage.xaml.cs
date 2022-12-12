using WorkPlusP2.ViewsModels.Dashboard;

namespace WorkPlusP2.Views.Dashboard;

public partial class DashboardPage : ContentPage
{
    public DashboardPage(DashboardPageViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }

}