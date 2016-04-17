using System;

namespace RuleGist.Conditionals
{
	public class LessThan : Conditional
	{
		public LessThan()
		{
			this.Symbol = "<";
			this.TextLabel = "less than";
			this.TypeCheck = typeof (Double);
		}

		public override bool Run<T>(T left, T right)
		{
			double leftd, rightd;

			if (!Double.TryParse(left.ToString(), out leftd) || !Double.TryParse(left.ToString(), out rightd))
			{
				throw new ArgumentException("left and right must be convertable to double");
			}
			return Convert.ToDouble(leftd) < Convert.ToDouble(rightd);
		}
	}
}