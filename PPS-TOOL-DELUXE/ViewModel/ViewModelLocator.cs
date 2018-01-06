/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:PPS_TOOL_DELUXE"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace PPS_TOOL_DELUXE.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register<DashboardViewModel>();
            SimpleIoc.Default.Register<WorkplacesViewModel>();
        }

        public DashboardViewModel Dashboard
        {
            get
            {
                return ServiceLocator.Current.GetInstance<DashboardViewModel>();
            }
        }

        public WorkplacesViewModel Workplaces
        {
            get
            {
                return ServiceLocator.Current.GetInstance<WorkplacesViewModel>();
            }
        }

        public static void Cleanup()
        {
            //TODO Clear the ViewModels
        }
    }
}