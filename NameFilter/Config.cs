using Exiled.API.Interfaces;
using System.Collections.Generic;

namespace NameFilter
{
	public class Config : IConfig
	{
		public bool IsEnabled { get; set; } = true;

		public List<string> Advertising { get; set; } = new List<string>();
		public List<string> Badwords { get; set; } = new List<string>();
	}
}
