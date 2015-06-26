using Microsoft.VisualStudio.TestTools.UnitTesting;
using RuleGist.DataAccess.Model;

namespace RuleGist.DataAccess.Test.Model
{
	[TestClass]
	public class CategoryTest
	{
		[TestMethod]
		public void ConstructorTest()
		{
			Category model = new Category()
			{
				CategoryId = 1,
				CategoryName = "blah"
			};
			Assert.IsNotNull(model);
			Assert.IsNotNull(model.CategoryId);
		}
	}
}
