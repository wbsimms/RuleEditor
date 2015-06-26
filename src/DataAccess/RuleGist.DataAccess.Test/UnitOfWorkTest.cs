using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RuleGist.DataAccess.Test
{
	[TestClass]
	public class UnitOfWorkTest
	{
		[TestMethod]
		public void ConstructorTest()
		{
			UnitOfWorkFactory factory = new UnitOfWorkFactory();
			Assert.IsNotNull(factory);
			var uow = factory.GetUnitOfWork();
			Assert.IsNotNull(uow);
			Assert.IsNotNull(uow.CategoryLogRepository);
			Assert.IsNotNull(uow.LogRepository);
			Assert.AreEqual(0,uow.Commit());
		}
	}
}
