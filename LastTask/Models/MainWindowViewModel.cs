using LastTask.Commands;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;

namespace LastTask.Models
{
	public class MainWindowViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		private string _text;

		public ICommand ChangeTextCommand { get; set; }
		public ICommand ShowWindowCommand { get; set; }
		public string Text
		{
			get => _text;
			set
			{
				_text = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Text"));
			}
		}
		private readonly WeatherService weatherService;

		public MainWindowViewModel()
		{
			Text = "Hello";
			ChangeTextCommand = new ButtonClickCommand(this);
			ShowWindowCommand = new SecondButtonClick(this);
			weatherService = new WeatherService();
		}
		public async void Button_Click()
		{
			var t = await weatherService.GetTemperatureAsync();
			Text = t.ToString();
		}
		public void Second_Button_Click()
		{
			MessageBox.Show("Hello");
		}
	}
}
