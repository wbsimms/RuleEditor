using System;
using System.Collections.Generic;
using System.Windows.Documents;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using RuleEditorDesktop.View;
using RuleGist.DataAccess;
using Syncfusion.Windows.Tools.Controls;

namespace RuleEditorDesktop.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
	    private IUnitOfWorkFactory factory;

        public MainViewModel(IUnitOfWorkFactory uowFactory)
        {
	        this.factory = uowFactory;

			this.RuleTypes = new List<string>(){"Equals Boolean", "Rule2", "Rule3"};
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

	    public const string SelectedRuleTypePropertyName = "SelectedRuleType";
	    private string selectedRuleType = "";

	    public string SelectedRuleType
	    {
		    get { return this.selectedRuleType; }
		    set
		    {
			    if (selectedRuleType == value)
			    {
				    return;
			    }
			    selectedRuleType = value;
				ShowRuleType(value);
			    RaisePropertyChanged(SelectedRuleTypePropertyName);
		    }
	    }


	    public const string RuleTabsPropertyName = "RuleTabs";
	    private List<TabItemExt> tabItemsExts = new List<TabItemExt>();

	    public List<TabItemExt> RuleTabs
	    {
		    get { return this.tabItemsExts; }
		    set
		    {
			    if (tabItemsExts == value)
			    {
				    return;
			    }
			    tabItemsExts = value;
			    RaisePropertyChanged(RuleTabsPropertyName);
		    }
	    }

	    public void ShowRuleType(string type)
	    {
		    if (type == "Equals Boolean")
		    {
			    var list = new List<TabItemExt>(this.tabItemsExts);
				list.Add(new RuleEqualsBoolean());
			    this.RuleTabs = list;
		    }
	    }
    }
}