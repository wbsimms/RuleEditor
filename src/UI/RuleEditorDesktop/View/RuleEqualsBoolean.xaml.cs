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
using Syncfusion.Windows.Tools.Controls;

namespace RuleEditorDesktop.View
{
	/// <summary>
	/// Interaction logic for RuleEqualsBoolean.xaml
	/// </summary>
	public partial class RuleEqualsBoolean : TabItemExt
	{
		public RuleEqualsBoolean()
		{
			InitializeComponent();
			this.Header = "(Untitled) - Equals Boolean";
		}
	}
}
