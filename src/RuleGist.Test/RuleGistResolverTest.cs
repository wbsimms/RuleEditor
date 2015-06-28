using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RuleGist.Test
{
	[TestClass]
	public class RuleGistResolverTest
	{
		[TestMethod]
		public void ConstructorTest()
		{
			RuleGistResolver resolver = RuleGistResolver.Instance;
			Assert.IsNotNull(resolver);
			resolver.Reset();
		}
	}
}
