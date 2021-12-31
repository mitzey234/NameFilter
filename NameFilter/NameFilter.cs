using Exiled.API.Features;

namespace NameFilter
{
	public class NameFilter : Plugin<Config>
	{
		public static NameFilter instance;
		private EventHandlers ev;

		private bool state = false;

		public override void OnEnabled()
		{
			if (state) return;

			instance = this;

			ev = new EventHandlers();
			Exiled.Events.Handlers.Player.Verified += ev.OnPlayerVerfied;

			state = true;
			base.OnEnabled();
		}

		public override void OnDisabled()
		{
			if (!state) return;

			Exiled.Events.Handlers.Player.Verified -= ev.OnPlayerVerfied;
			ev = null;

			state = false;
			base.OnDisabled();
		}

		public override string Name => "NameFilter";
	}
}
