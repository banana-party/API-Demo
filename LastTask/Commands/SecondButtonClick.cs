using LastTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LastTask.Commands
{
	class SecondButtonClick : ICommand
	{
		public event EventHandler CanExecuteChanged;
		private readonly MainWindowViewModel _viewModel;

		public SecondButtonClick(MainWindowViewModel viewModel)
		{
			_viewModel = viewModel;
		}
		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			_viewModel.Second_Button_Click();
		}
	}
}
