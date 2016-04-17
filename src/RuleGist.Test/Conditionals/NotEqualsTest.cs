using Microsoft.VisualStudio.TestTools.UnitTesting;
using RuleGist.Conditionals;

namespace RuleGist.Test.Conditionals
{
	[TestClass]
	public class NotEqualsTest
	{
		[TestMethod]
		public void ConstructorTest()
		{
			NotEquals neq = new NotEquals();
			Assert.IsNotNull(neq);
		}

		[TestMethod]
		public void EqualTrueTest()
		{
			NotEquals neq = new NotEquals();
			var result = neq.Run("r", "q");
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void EqualFalseTest()
		{
			NotEquals neq = new NotEquals();
			var result = neq.Run("w", "w");
			Assert.IsFalse(result);
		}

	}
}