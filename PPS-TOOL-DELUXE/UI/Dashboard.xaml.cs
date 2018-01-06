using System.Windows;
using PPS_TOOL_DELUXE.ViewModel;

namespace PPS_TOOL_DELUXE.UI
{
    public partial class Dashboard
    {
        private DashboardViewModel _viewModel;
        public Dashboard()
        {
            InitializeComponent();
            _viewModel = new DashboardViewModel();
        }

        private void btn_Periode_importieren_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.ImportPeriodClick();
        }

        private void btn_Periode_planen_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.PlanPeriodClick();
        }

        private void btn_Arbeitsplätze_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.WorkspacesClick();
        }

        private void btn_Erzeugnisse_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.ProduceItemsClick();
        }

        private void btn_Kaufteile_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.PurchaseItemsClick();
        }
    }
}
