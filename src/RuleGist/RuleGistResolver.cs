using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;

namespace RuleGist
{
	public class RuleGistResolver
	{
		private static RuleGistResolver INSTANCE = new RuleGistResolver();
		private static IUnityContainer _container;

		private RuleGistResolver()
		{
			Init();
		}

		public static RuleGistResolver Instance
		{
			get { return INSTANCE; }
		}

		private void Init()
		{
			_container = new UnityContainer();
			Register(_container);
		}

		public void Register(IUnityContainer container)
		{
		}

		public void Reset()
		{
			Init();
		}
	}


}
