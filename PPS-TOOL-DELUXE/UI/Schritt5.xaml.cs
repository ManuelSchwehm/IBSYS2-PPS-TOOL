using System.Windows;

namespace PPS_TOOL_DELUXE.UI
{
    public partial class Step5 : Window
    {
        public Step5()
        {
            InitializeComponent();
        }

        private void Schritt5_abbrechen_Click(object sender, RoutedEventArgs e)
        {
            var dashboard = new Dashboard();
            dashboard.Show();
            Close();
        }

        private void Schritt5_export_Click(object sender, RoutedEventArgs e)
        {
            var dashboard = new Dashboard();
            dashboard.Show();
            Close();
        }
    }
}
