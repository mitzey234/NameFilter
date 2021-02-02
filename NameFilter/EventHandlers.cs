using Exiled.Events.EventArgs;
using MEC;

namespace NameFilter
{
	class EventHandlers
	{
		public void OnPlayerVerfied(VerifiedEventArgs ev)
		{
			Timing.CallDelayed(1f, () =>
			{
				foreach (string phrase in NameFilter.instance.Config.Badwords)
				{
					string name = ev.Player.Nickname.ToLower();
					if (name.Contains(phrase))
					{
						ServerConsole.Disconnect(ev.Player.GameObject, $"<color=\"cyan\">Detected inappropriate phrase ({phrase}) in your username. Please change it before joining the server.\nIf you believe this was a mistake, contact a staff member in our discord: https://discord.gg/XUtkhUp</color>");
					}
				}

				foreach (string phrase in NameFilter.instance.Config.Advertising)
				{
					string name = ev.Player.Nickname.ToLower();
					if (name.Contains(phrase))
					{
						ServerConsole.Disconnect(ev.Player.GameObject, $"<color=\"cyan\">Detected advertising ({phrase}) in your username. Please change it before joining the server.\nIf you believe this was a mistake, contact a staff member in our discord: https://discord.gg/XUtkhUp</color>");
					}
				}
			});
		}
	}
}
