using Content.Shared._Local.Funny;
using Robust.Client.GameObjects;
using Robust.Client.Graphics;
using Robust.Shared.Graphics.RSI;
using Robust.Shared.Utility;

namespace Content.Client._Local.Funny{
    public sealed class FunnyComputerSystem : EntitySystem
    {
        [Dependency] private readonly UserInterfaceSystem _uiSystem = default!;
        public override void Initialize()
        {
            base.Initialize();
            SubscribeLocalEvent<FunnyComputerComponent, ComponentStartup>(Startup);
        }

        private void Startup(EntityUid entity, FunnyComputerComponent component, ComponentStartup startup)
        {

        }
    }
}
