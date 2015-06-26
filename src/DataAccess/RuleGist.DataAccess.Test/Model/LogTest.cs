using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RuleGist.DataAccess.Model;

namespace RuleGist.DataAccess.Test.Model
{
	[TestClass]
	public class LogTest
	{
		[TestMethod]
		public void ConstructorTest()
		{
			var model = new Log()
			{
				AppDomainName = "blah",
				Message = "blah",
				Severity = "blah",
				EventId = 1,
				FormattedMessage = "blah",
				LogId = 1,
				MachineName = "blah",
				Priority = 1,
				ProcessId = "blah",
				ThreadName = "blah",
				Timestamp = DateTime.UtcNow,
				Title = "blah",
				Win32ThreadId = "blah"
			};
			Assert.IsNotNull(model);
			Assert.IsNotNull(model.AppDomainName);
			Assert.IsNotNull(model.Message);
			Assert.IsNotNull(model.Severity);
			Assert.IsNotNull(model.EventId);
			Assert.IsNotNull(model.FormattedMessage);
			Assert.IsNotNull(model.LogId);
			Assert.IsNotNull(model.MachineName);
			Assert.IsNotNull(model.Priority);
			Assert.IsNotNull(model.ProcessId);
			Assert.IsNotNull(model.ThreadName);
			Assert.IsNotNull(model.Timestamp);
			Assert.IsNotNull(model.Timestamp);
			Assert.IsNotNull(model.Win32ThreadId);
		}
	}
}
