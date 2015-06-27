using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RuleEditorDesktop.Test
{
	[TestClass]
	public class RuleEditorDesktopResolverTest
	{
		[TestMethod]
		public void ConstructorTest()
		{
			RuleEditorDesktopResolver resolver= RuleEditorDesktopResolver.Instance;
			Assert.IsNotNull(resolver);
			resolver.Reset();
		}
	}
}
