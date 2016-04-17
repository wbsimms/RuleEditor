namespace RuleGist.Conditionals
{
	public class NotEquals : Conditional
	{
		public NotEquals()
		{
			this.Symbol = "!=";
			this.TextLabel = "doesn't equal";
		}

		public override bool Run<T>(T left, T right)
		{
			return left.ToString() != right.ToString();
		}
	}
}