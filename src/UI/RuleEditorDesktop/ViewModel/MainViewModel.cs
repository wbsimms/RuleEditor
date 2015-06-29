using System.Collections.Generic;
using System.Windows.Documents;
using GalaSoft.MvvmLight;
using RuleGist.DataAccess;

namespace RuleEditorDesktop.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
	    private IUnitOfWorkFactory factory;

        public MainViewModel(IUnitOfWorkFactory uowFactory)
        {
	        this.factory = uowFactory;

			this.RuleTypes = new List<string>(){"Rule1", "Rule2", "Rule3"};
        }

	    public const string RuleTypesPropertyName = "RuleTypes";
	    private List<string> ruleTypesList = new List<string>();

	    public List<string> RuleTypes
	    {
		    get { return this.ruleTypesList; }
		    set
		    {
			    if (ruleTypesList == value)
			    {
				    return;
			    }
			    ruleTypesList = value;
			    RaisePropertyChanged(RuleTypesPropertyName);
		    }
	    }

    }
}