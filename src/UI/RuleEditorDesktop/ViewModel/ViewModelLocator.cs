/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:RuleEditorDesktop"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using UnityServiceLocator = Microsoft.Practices.Unity.ServiceLocatorAdapter.UnityServiceLocator;

namespace RuleEditorDesktop.ViewModel
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
			IUnityContainer container = RuleEditorDesktopResolver.Instance.Container;
			ServiceLocator.SetLocatorProvider(() => new UnityServiceLocator(container));

		}

        public MainViewModel Main
        {
            get
            {
                return ServiceLocator.Current.GetInstance<MainViewModel>();
            }
        }
        
        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}