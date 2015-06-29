using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RuleGist.Template;

namespace RuleGist.Test.Template
{
	[TestClass]
	public class RuleEqualsBooleanTest
	{
		[TestMethod]
		public void ConstructorTest()
		{
			RuleEqualsBoolean rule = new RuleEqualsBoolean()
			{
				TargetType = RuleResultType.Bool,
				Description = "test rule",
				TargetProperty = "content",
				VisibleText = "rule text",
			};
			Assert.IsNotNull(rule);
			Assert.IsNotNull(rule.TargetType);
			Assert.IsNotNull(rule.Description);
			Assert.IsNotNull(rule.TargetProperty);
			Assert.IsNotNull(rule.VisibleText);
		}

		[TestMethod]
		public void ExecuteTrueTest()
		{
			RuleEqualsBoolean rule = new RuleEqualsBoolean()
			{
				TargetType = RuleResultType.Bool,
				Description = "test rule",
				TargetProperty = "contentbool",
				VisibleText = "rule text",
				TargetBool = true
			};

			var result = rule.Execute(new RuleModel() {RuleTarget = new Dictionary<string, object>()
			{
				{"contentbool",true},
				{"contentint",1},
				{"contentstring","blah"}
			}});
			Assert.AreEqual(true,rule.Result());
		}

		[TestMethod]
		public void ExecuteFalseTest()
		{
			RuleEqualsBoolean rule = new RuleEqualsBoolean()
			{
				TargetType = RuleResultType.Bool,
				Description = "test rule",
				TargetProperty = "contentboolfalse",
				VisibleText = "rule text",
				TargetBool = true
			};

			var result = rule.Execute(new RuleModel()
			{
				RuleTarget = new Dictionary<string, object>()
			{
				{"contentbool",true},
				{"contentboolfalse",false},
				{"contentint",1},
				{"contentstring","blah"}
			}
			});
			Assert.AreEqual(false, rule.Result());
		}

		[TestMethod]
		public void ExecuteExceptionTest()
		{
			RuleEqualsBoolean rule = new RuleEqualsBoolean()
			{
				TargetType = RuleResultType.Bool,
				Description = "test rule",
				TargetProperty = "contentbooldoesntexist",
				VisibleText = "rule text",
				TargetBool = true
			};

			var result = rule.Execute(new RuleModel()
			{
				RuleTarget = new Dictionary<string, object>()
			{
				{"contentbool",true},
				{"contentboolfalse",false},
				{"contentint",1},
				{"contentstring","blah"}
			}
			});
			Assert.IsTrue(result.HasError);
		}

		[TestMethod]
		public void ExecuteFaileTypeCheckTest()
		{
			RuleEqualsBoolean rule = new RuleEqualsBoolean()
			{
				TargetType = RuleResultType.Bool,
				Description = "test rule",
				TargetProperty = "contentbool",
				VisibleText = "rule text",
				TargetBool = true
			};

			var result = rule.Execute(new RuleModel()
			{
				RuleTarget = new Dictionary<string, object>()
			{
				{"contentbool",32.2},
				{"contentint",1},
				{"contentstring","blah"}
			}
			});
			Assert.IsTrue(result.HasError);
		}

	}
}
