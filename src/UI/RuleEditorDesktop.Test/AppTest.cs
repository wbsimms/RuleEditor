using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RuleEditorDesktop.Test
{
	[TestClass]
	public class AppTest
	{
		[TestMethod]
		public void ConstructorTest()
		{
			App app = new App();
			Assert.IsNotNull(app);
		}
	}
}
