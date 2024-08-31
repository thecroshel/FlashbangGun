using Exiled.API.Interfaces;

namespace FlashbangGun
{
    public class FlashbangGunConfig : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public bool Debug { get; set; } = false;
    }
}