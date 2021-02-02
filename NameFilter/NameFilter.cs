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
			Exiled.Events.Handlers.Player.Verified += ev.OnPlayerVerfied;
		}

		public override void OnDisabled()
		{
			base.OnDisabled();

			Exiled.Events.Handlers.Player.Verified -= ev.OnPlayerVerfied;
			ev = null;
		}

		public override string Name => "NameFilter";
	}
}
