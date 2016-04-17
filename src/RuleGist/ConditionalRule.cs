using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RuleGist.Conditionals;

namespace RuleGist
{
	public class ConditionalRule
	{
		public Conditional Conditional { get; set; }
		public string Left { get; set; }
		public string Right { get; set; }
	}
}
