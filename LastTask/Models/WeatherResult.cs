using System;
using System.Collections.Generic;
using System.Text;

namespace LastTask.Models
{
	class WeatherResult
	{
		public Coordinates coord { get; set; }
		public List<Condition> Weather { get; set; }
		public string Base { get; set; }
		public Main main { get; set; }
		public int visibility { get; set; }
		public Wind wind { get; set; }
		public Clouds clouds { get; set; }
		public int dt { get; set; }
	}
}
