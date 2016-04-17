using Microsoft.VisualStudio.TestTools.UnitTesting;
using RuleGist.Conditionals;

namespace RuleGist.Test.Conditionals
{
	[TestClass]
	public class EqualsTest
	{
		[TestMethod]
		public void ConstructorTest()
		{
			Equals eq = new Equals();
			Assert.IsNotNull(eq);
		}

		[TestMethod]
		public void EqualTrueTest()
		{
			Equals eq = new Equals();
			var result = eq.Run("q", "q");
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void EqualFalseTest()
		{
			Equals eq = new Equals();
			var result = eq.Run("w", "q");
			Assert.IsFalse(result);
		}

	}
}
