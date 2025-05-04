using Content.Server.Access.Systems;
using Content.Shared._Local.Funny;
using Content.Shared.Access.Systems;
using Content.Shared.Humanoid;

namespace Content.Server._Local.Funny
{
    public sealed class FunnyComputerSystem : EntitySystem
    {
        [Dependency] private readonly SharedUserInterfaceSystem _ui = default!;
        [Dependency] private readonly SharedAccessSystem _access = default!;
        [Dependency] private readonly IdCardSystem _idCardSystem = default!;

        public override void Initialize()
        {
            base.Initialize();

            SubscribeLocalEvent<FunnyComputerComponent, ComponentStartup>(OnStartup);
        }

        private void OnStartup(EntityUid owner, FunnyComputerComponent component, ComponentStartup args)
        {
            var query = new EntityQueryEnumerator<HumanoidAppearanceComponent>();

            while (query.MoveNext(out var uid, out var appearance))
            {

            }

        }
    }
}
