using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RuleEditorDesktop.ViewModel;

namespace RuleEditorDesktop.Test.ViewModel
{
	[TestClass]
	public class ViewModelLocatorTest
	{
		[TestMethod]
		public void ConstructorTest()
		{
			ViewModelLocator locator = new ViewModelLocator();
			Assert.IsNotNull(locator);
			Assert.IsNotNull(locator.Main);
		}

		public void CleanupTest()
		{
			ViewModelLocator.Cleanup();

		}
	}
}
