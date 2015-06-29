using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogicEngine.Lib;

namespace RuleGist.Template
{
	public class RuleEqualsBoolean : RuleTemplateBase, IRule<RuleModel>
	{
		public RuleEqualsBoolean()
		{
			this.VisibleText = "equals";
			this.Description = "A test if a property is equal to a value";
		}

		public IEngineResult Execute(RuleModel model)
		{
			EngineResult result = new EngineResult() {TimeStart = DateTime.UtcNow};

			if (!model.RuleTarget.ContainsKey(this.TargetProperty))
			{
				result.Error = string.Format("TargetProperty '{0}' does not exist in model",this.TargetProperty);
				result.TimeEnd = DateTime.UtcNow;
				return result;
			}

			if (CheckType(model.RuleTarget[this.TargetProperty]) != null)
			{
				result.Error = string.Format("Failed type check for value {0}", model.RuleTarget[this.TargetProperty]);
				result.TimeEnd = DateTime.UtcNow;
				return result;
			}

			this.ResultBool = ((bool) model.RuleTarget[this.TargetProperty] == this.TargetBool);
	
			result.TimeEnd = DateTime.UtcNow;
			return result;
		}
	}
}
