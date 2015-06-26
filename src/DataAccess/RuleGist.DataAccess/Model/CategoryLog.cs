using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RuleGist.DataAccess.Model
{
	public class CategoryLog : Entity
	{
		[Key]
		public int CategoryLogId { get; set; }
		public int CategoryId { get; set; }
		public virtual ICollection<Category> Category { get; set; }
		public int LogId { get; set; }
		public Log Log { get; set; }
	}
}