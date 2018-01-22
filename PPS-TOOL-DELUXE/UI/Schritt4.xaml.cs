using System.Windows;
using Microsoft.Practices.ServiceLocation;
using PPS_TOOL_DELUXE.ViewModel;

namespace PPS_TOOL_DELUXE.UI
{
    public partial class Step4 : Window
    {
        public Step4()
        {
            InitializeComponent();
        }

        private void Schritt4_abbrechen_Click(object sender, RoutedEventArgs e)
        {
            var dashboard = new Dashboard();
            dashboard.Show();
            Close();
        }

        private void Schritt4_weiter_Click(object sender, RoutedEventArgs e)
        {
            var window = new Step5();
            window.Show();
            Close();
        }

        private void Schritt4_ContentRendered(object sender, System.EventArgs e)
        {
            var viewModel = ServiceLocator.Current.GetInstance<Step4ViewModel>();
            viewModel.Initialize();
        }
    }
}
