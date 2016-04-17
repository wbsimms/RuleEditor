using System;

namespace RuleGist.Conditionals
{
	public abstract class Conditional
	{
		public string Symbol { get; set; }
		public string TextLabel { get; set; }
		public abstract bool Run<T>(T left, T right);
		public Type TypeCheck { get; set; } = (typeof (string));
	}
}
