using RuleGist.DataAccess.Model;

namespace RuleGist.DataAccess.Repository
{
	public interface ILogRepository<T> : IRepositoryBase<T> where T : Entity 
	{
	}

	public class LogRepository<T> : RepositoryBase<T>, ILogRepository<T> where T : Entity
	{
		public LogRepository(IRuleGistContext context)
			: base(context)
		{
		}
	}

	public interface ICategoryLogRepository<T> : IRepositoryBase<T> where T : Entity
	{
	}

	public class CategoryLogRepository<T> : RepositoryBase<T>, ICategoryLogRepository<T> where T : Entity
	{
		public CategoryLogRepository(IRuleGistContext context)
			: base(context)
		{
		}
	}

}
