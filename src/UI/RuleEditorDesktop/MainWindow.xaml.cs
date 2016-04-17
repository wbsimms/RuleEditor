using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Practices.ServiceLocation;
using RuleEditorDesktop.ViewModel;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;

namespace RuleEditorDesktop
{

	public partial class MainWindow : ChromelessWindow
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void RuleTabControlExt_OnTabClosed(object sender, CloseTabEventArgs e)
		{
			var itemToRemove = e.TargetTabItem as TabItemExt;
			ServiceLocator.Current.GetInstance<MainViewModel>().RuleTabs.Remove(itemToRemove);
		}
	}
}
