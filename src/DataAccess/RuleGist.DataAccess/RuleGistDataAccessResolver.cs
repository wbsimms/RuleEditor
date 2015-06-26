using Microsoft.Practices.Unity;
using RuleGist.DataAccess.Model;
using RuleGist.DataAccess.Repository;

namespace RuleGist.DataAccess
{
	public class RuleGistDataAccessResolver
	{
		static RuleGistDataAccessResolver INSTANCE = new RuleGistDataAccessResolver();
		private UnityContainer container;


		private RuleGistDataAccessResolver()
		{
			Init();
		}

		private void Init()
		{
			container = new UnityContainer();
			Register(container);
		}

		public void Register(IUnityContainer container)
		{
			container.RegisterType<IRuleGistContext, RuleGistContext>(new PerResolveLifetimeManager());
			container.RegisterType<IUnitOfWork, UnitOfWork>(new PerResolveLifetimeManager());
			container.RegisterType<ILogRepository<Log>, LogRepository<Log>>();
			container.RegisterType<ICategoryLogRepository<CategoryLog>, CategoryLogRepository<CategoryLog>>();

			container.RegisterType<IUnitOfWorkFactory, UnitOfWorkFactory>();
		}

		public UnityContainer Container
		{
			get { return this.container; }
		}

		public static RuleGistDataAccessResolver Instance
		{
			get { return INSTANCE; }
		}

		public void Reset()
		{
			this.Init();
		}
	}
}
