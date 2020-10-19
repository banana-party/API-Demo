using LastTask.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace LastTask
{
	class WeatherService : IDisposable
	{
		public HttpClient _client;
		public void Dispose()
		{
			_client.Dispose();
		}
		public WeatherService()
		{
			_client = new HttpClient();
		}
		public async Task<string> GetTemperatureAsync()
		{
			HttpClient client = new HttpClient();
			var res = await client.GetStringAsync("http://api.openweathermap.org/data/2.5/weather?q=Novosibirsk&units=metric&appid=d7f95be2d3e944611000e0b9d73b67e7");
			var weather = JsonConvert.DeserializeObject<WeatherResult>(res);
			return weather.main.temp;
		}
	}
}
