using Exiled.API.Enums;
using Exiled.API.Features;
using Exiled.API.Features.Items;
using Exiled.Events.EventArgs;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using UnityEngine;

namespace FlashbangGun
{
    public class EventHandlers
    {
        private readonly FlashbangGun _plugin;

        public EventHandlers(FlashbangGun plugin) => _plugin = plugin;

        public void OnShooting(ShootingEventArgs ev)
        {
            // you can change weapon type from there
            if (ev.Player.CurrentItem?.Type == ItemType.GunCom45)
            {
                ev.IsAllowed = false;

                // you can change to frag grenade if you want
                ev.Player.ThrowGrenade(ProjectileType.Flashbang);

                if (_plugin.Config.Debug)
                {
                    Log.Info($"{ev.Player.Nickname} this guy fired the flashbang gun.");
                }
            }
        }
    }
}