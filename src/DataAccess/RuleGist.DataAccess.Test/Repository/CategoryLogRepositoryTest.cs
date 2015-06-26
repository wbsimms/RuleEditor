using System;
using System.Data.Entity;
using System.Linq;
using System.Transactions;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RuleGist.DataAccess.Test.Repository
{
	[TestClass]
	public class CategoryLogRepositoryTest
	{
		[TestMethod]
		public void GetSomeTest()
		{
			Logger.Instance.Writer.Write("testing");
			using (var scope = new TransactionScope())
			{
				using (var work = RuleGistDataAccessResolver.Instance.Container.Resolve<IUnitOfWork>())
				{
					var retval = work.CategoryLogRepository.GetAll().Include(x => x.Log);
					Assert.IsNotNull(retval.First().Log.Message);
					string message = retval.First().Log.Message;
					Console.WriteLine(message);
					Assert.IsNotNull(retval);
				}
			}
		}
	}
}
