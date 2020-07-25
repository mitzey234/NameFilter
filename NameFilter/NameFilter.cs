using Exiled.API.Features;

namespace NameFilter
{
	public class NameFilter : Plugin<Config>
	{
		public static NameFilter instance;
		private EventHandlers ev;

		public override void OnEnabled()
		{
			base.OnEnabled();

			if (!Config.IsEnabled) return;

			instance = this;

			ev = new EventHandlers();
			Exiled.Events.Handlers.Player.Joined += ev.OnPlayerJoin;
		}

		public override void OnDisabled()
		{
			base.OnDisabled();

			Exiled.Events.Handlers.Player.Joined -= ev.OnPlayerJoin;
			ev = null;
		}

		public override string Name => "NameFilter";
	}
}
