namespace RuleGist.Conditionals
{
	public class Equals : Conditional
	{
		public Equals()
		{
			this.Symbol = "=";
			this.TextLabel = "equals";
		}

		public override bool Run<T>(T left, T right)
		{
			return left.ToString() == right.ToString();
		}
	}
}