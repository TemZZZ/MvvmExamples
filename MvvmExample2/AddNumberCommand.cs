using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace MvvmExample2
{
	public class AddNumberCommand : ICommand
	{
		private readonly MainViewModel _viewModel;

		public AddNumberCommand(MainViewModel viewModel)
		{
			_viewModel = viewModel;
		}

		public bool CanExecute(object parameter)
		{
			//return !(parameter is null);
			return true;
		}

		public void Execute(object parameter)
		{
			_viewModel.GetSummator().AddNumber(_viewModel.NewNumber);
		}

		public event EventHandler CanExecuteChanged;
	}
}
