using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using RuleGist.DataAccess;

namespace RuleEditorDesktop.ViewModel
{
	public class RuleEqualsBooleanViewModel : ViewModelBase
	{
		private IUnitOfWorkFactory factory;

		public RuleEqualsBooleanViewModel(IUnitOfWorkFactory uowFactory)
		{
			this.factory = uowFactory;
		}


	}
}
