using System;

namespace RuleGist.Template
{
	public abstract class RuleTemplateBase
	{
		public string VisibleText { get; set; }
		public string Description { get; set; }
		protected bool ResultBool { get; set; }
		public bool TargetBool { get; set; }
		protected int ResultInt { get; set; }
		public int TargetInt { get; set; }
		protected string ResultString { get; set; }
		public string TargetString { get; set; }
		public string TargetProperty { get; set; }
		public RuleResultType TargetType { get; set; }

		public object Result()
		{
			switch (TargetType)
			{
				case RuleResultType.Bool:
					return ResultBool;
				case RuleResultType.Int:
					return ResultInt;
				case RuleResultType.String:
					return ResultString;
				default:
					throw new ArgumentException("Unknown type");
			}
		}

		protected string CheckType(object value)
		{
			string error = "failed CheckType on";
			if (TargetType == RuleResultType.Bool)
			{
				var castCheck = value as bool?;
				if (castCheck == null) return error;
			}

			if (TargetType == RuleResultType.Int)
			{
				var castCheck = value as int?;
				if (castCheck == null) return error;
			}

			if (TargetType == RuleResultType.String)
			{
				var castCheck = value as string;
				if (castCheck == null) return error;
			}

			return null;
		}


	}

	public enum RuleResultType
	{
		Bool,
		Int,
		String
	}
}