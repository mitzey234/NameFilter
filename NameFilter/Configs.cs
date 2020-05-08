using System.Collections.Generic;
using System.Linq;

namespace NameFilter
{
	class Configs
	{
		internal static List<string> advertising;
		internal static List<string> badwords;

		internal static void LoadConfigs()
		{
			advertising = Plugin.Config.GetString("nf_advertising_blacklist").Split(',').Select(x => x.Trim()).ToList();
			badwords = Plugin.Config.GetString("nf_badwords_blacklist").Split(',').Select(x => x.Trim()).ToList();
		}
	}
}
