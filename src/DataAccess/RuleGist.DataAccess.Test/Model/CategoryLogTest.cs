using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RuleGist.DataAccess.Model;

namespace RuleGist.DataAccess.Test.Model
{
	[TestClass]
	public class CategoryLogTest
	{
		[TestMethod]
		public void ConstructorTest()
		{
			CategoryLog model = new CategoryLog()
			{
				Category = new List<Category>(),
				CategoryId = 1,
				Log = new Log(),
				LogId = 1,
				CategoryLogId = 1
			};
			Assert.IsNotNull(model);
			Assert.IsNotNull(model.Category);
			Assert.IsNotNull(model.CategoryId);
			Assert.IsNotNull(model.Log);
			Assert.IsNotNull(model.Log);
			Assert.IsNotNull(model.CategoryLogId);

		}
	}
}
