using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RuleGist.Template;

namespace RuleGist.Test.Template
{
	[TestClass]
	public class RuleTemplateBaseTest
	{
		[TestMethod]
		public void ConstructorTest()
		{
			RuleTemplateBase template = new RuleEqualsBoolean();
			Assert.IsNotNull(template);
		}
	}
}
