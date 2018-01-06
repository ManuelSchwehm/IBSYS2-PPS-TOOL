using System.Windows;
using PPS_TOOL_DELUXE.Masterdata.Workplaces;
using PPS_TOOL_DELUXE.ViewModel;

namespace PPS_TOOL_DELUXE.UI
{
    public partial class Arbeitsplatzverwaltung : Window
    {
        private WorkplacesViewModel _viewModel;

        public Arbeitsplatzverwaltung()
        {
            InitializeComponent();
            _viewModel = new WorkplacesViewModel();
        }

        private void btn_Arbeitsplatzverwaltung_zurück_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.BackClick(); //TODO
        }

        private void btn_Arbeitsplatzverwaltung_bearbeiten_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.EditClick();
        }

        private void DataGrid_Initialized(object sender, System.EventArgs e)
        {
            workspacesGrid.ItemsSource = Model.MasterData.Workspaces.WorkspacesModel.GetInstance().GetWorkspaces();
        }

        private void workspacesGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (workspacesGrid.SelectedIndex == -1)
            {
                btn_Arbeitsplatzverwaltung_bearbeiten.IsEnabled = false;
                return;
            }
            btn_Arbeitsplatzverwaltung_bearbeiten.IsEnabled = true;
        }
    }
}
