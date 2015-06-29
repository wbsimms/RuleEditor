﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RuleEditorDesktop.ViewModel;
using RuleGist.DataAccess;

namespace RuleEditorDesktop.Test.ViewModel
{
	[TestClass]
	public class MainViewModelTest
	{
		[TestMethod]
		public void ConstructorTest()
		{
			Mock<IUnitOfWorkFactory> factory = new Mock<IUnitOfWorkFactory>();
			factory.Setup(x => x.GetUnitOfWork());

			MainViewModel model = new MainViewModel(factory.Object);
			Assert.IsNotNull(model);
		}

		[TestMethod]
		public void RuleTypesTest()
		{
			Mock<IUnitOfWorkFactory> factory = new Mock<IUnitOfWorkFactory>();
			factory.Setup(x => x.GetUnitOfWork());

			MainViewModel model = new MainViewModel(factory.Object);
			var ruleTypes = model.RuleTypes;
			Assert.IsNotNull(ruleTypes);

		}
	}
}
