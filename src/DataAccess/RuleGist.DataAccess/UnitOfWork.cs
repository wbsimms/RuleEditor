using System;
using Microsoft.Practices.Unity;
using RuleGist.DataAccess.Model;
using RuleGist.DataAccess.Repository;

namespace RuleGist.DataAccess
{
	public interface IUnitOfWork : IDisposable
	{

		ICategoryLogRepository<CategoryLog> CategoryLogRepository { get; }
		ILogRepository<Log> LogRepository { get; } 
		int Commit();
	}

	public class UnitOfWork : IUnitOfWork
	{
		private RuleGistContext context;

		public UnitOfWork(IRuleGistContext ruleGistContext, 
			ICategoryLogRepository<CategoryLog> categoryLog,
			ILogRepository<Log> log )
		{
			this.context = ruleGistContext as RuleGistContext;
			this.CategoryLogRepository = categoryLog;
			this.LogRepository = log;
		}

		public ICategoryLogRepository<CategoryLog> CategoryLogRepository { get; set; }
		public ILogRepository<Log> LogRepository { get; set; }

		public int Commit()
		{
			return this.context.SaveChanges();
		}

		public void Dispose()
		{
			if (context != null)
			{
				context.Dispose();
				context = null;
			}
		}
	}

	public interface IUnitOfWorkFactory
	{
		IUnitOfWork GetUnitOfWork();
	}

	public class UnitOfWorkFactory : IUnitOfWorkFactory
	{
		public IUnitOfWork GetUnitOfWork()
		{
			return RuleGistDataAccessResolver.Instance.Container.Resolve<IUnitOfWork>();
		}
	}
}