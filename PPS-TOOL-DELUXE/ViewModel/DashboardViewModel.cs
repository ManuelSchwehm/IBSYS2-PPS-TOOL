using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Xml;
using GalaSoft.MvvmLight;
using Microsoft.Win32;
using PPS_TOOL_DELUXE.Masterdata.Workplaces.UI;
using PPS_TOOL_DELUXE.Model;
using PPS_TOOL_DELUXE.UI;

namespace PPS_TOOL_DELUXE.ViewModel
{
    public class DashboardViewModel : ViewModelBase
    {

        private CultureInfo CurrentLanguage { get; set; }

        private ObservableCollection<Period> _periods;
        public ObservableCollection<Period> Periods
        {
            get { return _periods; }
            set
            {
                _periods = value;
                //RaisePropertyChanged();
            }
        }

        private results LastPeriod { get; set; }

        //TODO Binding
        private Label LabPage;
        private Label LabDetail;
        private Label LabMasterAdmin;
        private Button BtnImport;
        private Button BtnPlan;
        private Button BtnWorkplaces;
        private Button BtnProduces;
        private Button BtnPurchases;
        private Button BtnGerman;
        private Button BtnEnglish;
        private Button BtnFrench;
        private DataGrid GridPeriods;
        //TODO dataGrid headers

        
        public DashboardViewModel()
        {
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            Periods = new ObservableCollection<Period>();
            LoadXmlInputs();
            /*if (Periods.Count > 0)
                GridPeriods.ItemsSource = Periods;
            else BtnPlan.IsEnabled = false;*/ //TODO fix this
        }

        private void LoadXmlInputs()
        {
            var resultsPath = "./results/";
            if (!Directory.Exists(resultsPath))
                Directory.CreateDirectory(resultsPath);

            var files = Directory.GetFiles(resultsPath);
            files.ToList().ForEach(path =>
            {
                if (File.Exists(path))
                    LoadXmlInput(path);
            });

            //Periods = Periods.OrderByDescending(p => p.Id).ToList(); //TODO handle duplicate ids
        }

        private void LoadXmlInput(string path)
        {
            var settings = new XmlReaderSettings();
            var xmlReader = XmlReader.Create(path, settings);
            var serializer = new System.Xml.Serialization.XmlSerializer(typeof(results));
            var result = (results)serializer.Deserialize(xmlReader);
            xmlReader.Close();
            Periods.Add(new Period
            {
                Id = result.period,
                Efficiency = result.result.general.effiency.current,
                Profit = result.result.summary.profit.current,
                Totalprofit = result.result.summary.profit.all,
                Workload = result.result.general.relpossiblenormalcapacity.current
            });

            if (LastPeriod == null || LastPeriod.period < result.period)
                LastPeriod = result;
        }

        public void WorkspacesClick()
        {
            var workspacesWindow = new Arbeitsplatzverwaltung();
            workspacesWindow.Show();
        }

        public void ImportPeriodClick()
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "XML (*.xml)|*.xml";
            dialog.Title = "XML Import";
            var fileOpened = dialog.ShowDialog();

            if (fileOpened.GetValueOrDefault() && File.Exists(dialog.FileName))
            {
                var settings = new XmlReaderSettings();
                var xmlReader = XmlReader.Create(dialog.FileName, settings);
                var serializer = new System.Xml.Serialization.XmlSerializer(typeof(results));
                var result = (results)serializer.Deserialize(xmlReader);
                xmlReader.Close();

                var periodExists = false;
                foreach (var period in Periods)
                {
                    if (period.Id == result.period) periodExists = true;
                }

                if (periodExists)
                {
                    MessageBox.Show($"Period #{result.period} already exists", "Warning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                    return;
                }

                var path = "./results/period" + result.period + ".xml";

                var settingsWriter = new XmlWriterSettings();
                var xmlWriter = XmlWriter.Create(path, settingsWriter);
                serializer.Serialize(xmlWriter, result);
                xmlWriter.Close();

                LoadDashboard();
            }
        }

        public void PlanPeriodClick()
        {
            throw new NotImplementedException();
        }

        public void ProduceItemsClick()
        {
            throw new NotImplementedException();
        }

        public void PurchaseItemsClick()
        {
            throw new NotImplementedException();
        }

        public void FlagDeClick() => ReloadDashboard(new CultureInfo("de-DE"));

        public void FlagEnClick() => ReloadDashboard(new CultureInfo("en-GB"));

        public void FlagFrClick() => ReloadDashboard(new CultureInfo("fr-FR"));

        private void ReloadDashboard(CultureInfo locale)
        {
            CurrentLanguage = locale;
            throw new NotImplementedException();
        }
    }
}
