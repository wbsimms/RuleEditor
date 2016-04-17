using Microsoft.VisualStudio.TestTools.UnitTesting;
using RuleGist.Conditionals;

namespace RuleGist.Test.Conditionals
{
	[TestClass]
	public class LessThanTest
	{
		[TestMethod]
		public void ConstructorTest()
		{
			LessThan cond = new LessThan();
			Assert.IsNotNull(cond);
		}

		[TestMethod]
		public void EqualTrueTest()
		{
			LessThan cond = new LessThan();
			var result = cond.Run(34, 56);
			Assert.IsTrue(result);
		}

		[TestMethod]
		public void EqualFalseTest()
		{
			LessThan cond = new LessThan();
			var result = cond.Run(64, 56);
			Assert.IsFalse(result);
		}

	}
}