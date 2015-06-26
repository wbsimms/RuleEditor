using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RuleGist.DataAccess.Test
{
	[TestClass]
	public class RuleGistContextTest
	{
		[TestMethod]
		public void ConstructorTest()
		{
			RuleGistContext context = new RuleGistContext();
			Assert.IsNotNull(context);
			Assert.IsNotNull(context.Categories);
			Assert.IsNotNull(context.Logs);
			Assert.IsNotNull(context.CategoryLogs);
		}
	}
}
