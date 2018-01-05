using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PPS_TOOL_DELUXE.Model.MasterData.ProduceItems;
using PPS_TOOL_DELUXE.Model.MasterData.PurchaseItems;
using PPS_TOOL_DELUXE.Model.MasterData.Workspaces;

namespace PPS_TOOL_DELUXE.Model
{
    class BaseController
    {
        protected void ChangeView()
        {
            //TODO
        }

        protected void LoadDashboard()
        {
            //TODO
        }

        protected void CloseApplicationWithError()
        {
            //TODO
        }

        protected List<workspacesWorkspace> GetWorkspaces()
        {
            try
            {
                return WorkspacesModel.GetInstance().GetWorkspaces();
            }
            catch(Exception e)
            {
                throw new Exception("No workspaces could be loaded", e);
            }
        }

        protected List<produceItemsItem> GetProduceItems()
        {
            try
            {
                return ProduceItemsModel.GetInstance().GetProduceItems();
            }
            catch (Exception e)
            {
                throw new Exception("No produce items could be loaded", e);
            }
        }

        protected List<purchaseItemsItem> GetPurchaseItems()
        {
            try
            {
                return PurchaseItemsModel.GetInstance().GetPurchaseItems();
            }
            catch (Exception e)
            {
                throw new Exception("No purchase items could be loaded", e);
            }
        }
    }
}
