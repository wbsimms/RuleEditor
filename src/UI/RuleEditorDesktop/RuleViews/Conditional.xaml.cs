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
using RuleGist.Conditionals;

namespace RuleEditorDesktop.RuleViews
{
	/// <summary>
	/// Interaction logic for Equals.xaml
	/// </summary>
	public partial class Conditional : UserControl
	{
		public Conditional()
		{
			InitializeComponent();
			this.conditionals.ItemsSource = new List<string> {"=", "!=", "<"};
		}

		private void ConditionalButton_OnClick(object sender, RoutedEventArgs e)
		{
			bool result = false;
			if (this.conditionals.SelectedValue.ToString() == "=")
			{
				result = new Equals().Run(this.left.Text, this.right.Text);
			}

			if (this.conditionals.SelectedValue.ToString() == "!=")
			{
				result = new NotEquals().Run(this.left.Text, this.right.Text);
			}

			if (this.conditionals.SelectedValue.ToString() == "<")
			{
				result = new LessThan().Run(this.left.Text, this.right.Text);
			}


			this.conditionalResult.Text = result.ToString();

		}
	}
}
