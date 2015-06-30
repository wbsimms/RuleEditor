using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using RuleEditorDesktop.ViewModel;
using RuleGist.DataAccess;

namespace RuleEditorDesktop
{
	public class RuleEditorDesktopResolver
	{
		private static RuleEditorDesktopResolver INSTANCE = new RuleEditorDesktopResolver();
		private static IUnityContainer _container;

		private RuleEditorDesktopResolver()
		{
			Init();
		}

		public static RuleEditorDesktopResolver Instance {
			get { return INSTANCE; } 
		}

		private void Init()
		{
			_container = new UnityContainer();
			Register(_container);
		}

		public void Register(IUnityContainer container)
		{
			RuleGistDataAccessResolver.Instance.Register(container);
			container.RegisterType<MainViewModel, MainViewModel>(new ContainerControlledLifetimeManager());
		}

		public IUnityContainer Container { get { return _container; } }

		public void Reset()
		{
			Init();
		}
	}
}
