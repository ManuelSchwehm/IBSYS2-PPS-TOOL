using System;
using System.Collections.ObjectModel;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using PPS_TOOL_DELUXE.Model.MasterData.Workspaces;

namespace PPS_TOOL_DELUXE.ViewModel
{
    public class WorkplacesViewModel : ViewModelBase
    {
        public RelayCommand<Window> CloseWindowCommand { get; private set; }
        private ObservableCollection<workspacesWorkspace> _workspaces;
        public ObservableCollection<workspacesWorkspace> Workspaces { get; set; }

        public WorkplacesViewModel()
        {
            this.CloseWindowCommand = new RelayCommand<Window>(this.CloseWindow);
        }

        private void CloseWindow(Window window)
        {
            if (window != null)
            {
                window.Close();
            }
        }

        internal void BackClick()
        {
            throw new NotImplementedException();
        }

        internal void EditClick()
        {
            throw new NotImplementedException();
        }
    }
}
