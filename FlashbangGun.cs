using Exiled.API.Features;
using System;
using Player = Exiled.Events.Handlers.Player;

namespace FlashbangGun
{
    public class FlashbangGun : Plugin<FlashbangGunConfig>
    {
        public override string Name => "FlashbangGun";
        public override string Author => "thecroshel";
        public override string Prefix => "flashgun";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(8, 9, 11);

        private EventHandlers _eventHandlers;

        public override void OnEnabled()
        {
            if (!Config.IsEnabled) return;

            _eventHandlers = new EventHandlers(this);
            Player.Shooting += _eventHandlers.OnShooting;

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Player.Shooting -= _eventHandlers.OnShooting;

            _eventHandlers = null;
            base.OnDisabled();
        }
    }
}