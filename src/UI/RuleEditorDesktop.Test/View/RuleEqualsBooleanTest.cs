using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RuleEditorDesktop.View;

namespace RuleEditorDesktop.Test.View
{
	[TestClass]
	public class RuleEqualsBooleanTest
	{
		[TestMethod]
		public void ConstructorTest()
		{
			RuleEqualsBoolean view = new RuleEqualsBoolean();
			Assert.IsNotNull(view);
		}
	}
}
