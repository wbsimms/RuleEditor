using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using RuleGist.DataAccess.Model;

namespace RuleGist.DataAccess.Repository
{
	public interface IRepositoryBase<T> where T : Entity
	{
		IQueryable<T> GetAll();
		IQueryable<T> Get(Expression<Func<T, bool>> expression);
		T Add(T entity);
		IEnumerable<T> AddRange(IEnumerable<T> entities);
	}

	public class RepositoryBase<T> : IRepositoryBase<T> where T : Entity
	{
		protected RuleGistContext context;

		public IEnumerable<T> AddRange(IEnumerable<T> entities)
		{
			return context.Set<T>().AddRange(entities);
		}

		public T Add(T entity)
		{
			return context.Set<T>().Add(entity);
		}

		public IQueryable<T> GetAll()
		{
			return context.Set<T>();
		}

		public IQueryable<T> Get(Expression<Func<T, bool>> expression)
		{
			return context.Set<T>().Where(expression);
		}
		public RepositoryBase(IRuleGistContext context)
		{
			this.context = context as RuleGistContext;
		}
	}
}