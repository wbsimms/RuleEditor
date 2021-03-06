using GalaSoft.MvvmLight;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;

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