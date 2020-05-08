using EXILED;
using MEC;

namespace NameFilter
{
	class EventHandlers
	{
		public void OnWaitingForPlayers()
		{
			Configs.LoadConfigs();
		}

		public void OnPlayerJoin(PlayerJoinEvent ev)
		{
			Timing.CallDelayed(1f, () =>
			{
				foreach (string phrase in Configs.badwords)
				{
					string name = ev.Player.nicknameSync.Network_myNickSync.ToLower();
					if (name.Contains(phrase))
					{
						ServerConsole.Disconnect(ev.Player.gameObject, $"<color=\"cyan\">Detected inappropriate phrase ({phrase}) in your username. Please change it before joining the server.\nIf you believe this was a mistake, contact a staff member in our discord: https://discord.gg/XUtkhUp</color>");
					}
				}

				foreach (string phrase in Configs.advertising)
				{
					string name = ev.Player.nicknameSync.Network_myNickSync.ToLower();
					if (name.Contains(phrase))
					{
						ServerConsole.Disconnect(ev.Player.gameObject, $"<color=\"cyan\">Detected advertising ({phrase}) in your username. Please change it before joining the server.\nIf you believe this was a mistake, contact a staff member in our discord: https://discord.gg/XUtkhUp</color>");
					}
				}
			});
		}
	}
}
