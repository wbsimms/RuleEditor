using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RuleEditorDesktop.ViewModel;

namespace RuleEditorDesktop.Test.ViewModel
{
	[TestClass]
	public class MainViewModelTest
	{
		[TestMethod]
		public void ConstructorTest()
		{
			MainViewModel model = new MainViewModel();
			Assert.IsNotNull(model);
		}
	}
}
