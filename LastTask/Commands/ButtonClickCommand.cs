using LastTask.Models;
using System;
using System.Windows.Input;

namespace LastTask
{
	class ButtonClickCommand : ICommand
	{
		public event EventHandler CanExecuteChanged;
		private readonly MainWindowViewModel _viewModel;

		public ButtonClickCommand(MainWindowViewModel viewModel)
		{
			_viewModel = viewModel;
		}
		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			_viewModel.Button_Click();
		}
	}
}
