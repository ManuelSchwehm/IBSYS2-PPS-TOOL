using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using Microsoft.Practices.ServiceLocation;
using PPS_TOOL_DELUXE.Model;
using PPS_TOOL_DELUXE.Model.MasterData.ProduceItems;
using PPS_TOOL_DELUXE.Model.Output;

namespace PPS_TOOL_DELUXE.ViewModel
{
    public class Step4ViewModel : ViewModelBase
    {
        private results rLastPeriod;
        private ExportModel exportModel;

        public ObservableCollection<ProductionOrderModel> ProduceItemsAll { get; } =
            new ObservableCollection<ProductionOrderModel>();

        public ObservableCollection<int> ProduceItemIds { get; set; }

        public Step4ViewModel()
        {
            NextCommand = new RelayCommand(NextClick);
        }

        public RelayCommand NextCommand;

        private void NextClick()
        {
            throw new System.NotImplementedException();
        }

        public void Initialize()
        {
            rLastPeriod = ServiceLocator.Current.GetInstance<DashboardViewModel>().LastPeriod;
            exportModel = ServiceLocator.Current.GetInstance<MainViewModel>().export;

            var allProduceItems = ProduceItemsModel.GetInstance().GetProduceItems();
            ProduceItemIds = new ObservableCollection<int>(allProduceItems.Select(p => p.id));

            var listOfIds = ProduceItemIds.ToList();
            exportModel.productionList.ForEach(item =>
            {
                ProduceItemsAll.Add(new ProductionOrderModel(new List<int>(listOfIds), item.article, item.quantity));
            });

            //TODO empty line at end
        }
    }
}
