using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RuleGist.DataAccess.Test
{
	[TestClass]
	public class RuleGistDataAccessResolverTest
	{
		[TestMethod]
		public void ConstructorTest()
		{
			RuleGistDataAccessResolver resolver = RuleGistDataAccessResolver.Instance;
			Assert.IsNotNull(resolver);
		}

		[TestMethod]
		public void ResetTest()
		{
			RuleGistDataAccessResolver.Instance.Reset();
		}
	}
}
