using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RuleGist.DataAccess.Model;

namespace RuleGist.DataAccess
{
	public interface IRuleGistContext
	{
		DbSet<Log> Logs { get; set; }
		DbSet<Category> Categories { get; set; }
		DbSet<CategoryLog> CategoryLogs { get; set; }
	}

	public class RuleGistContext : DbContext, IRuleGistContext
	{
		public RuleGistContext() : base("DefaultConnection")
		{

		}
		public DbSet<Log> Logs { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<CategoryLog> CategoryLogs { get; set; }
	}
}
