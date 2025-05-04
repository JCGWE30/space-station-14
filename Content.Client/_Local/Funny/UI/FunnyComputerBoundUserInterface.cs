
using Content.Client.Communications.UI;
using Content.Shared.CCVar;
using Content.Shared.Chat;
using Content.Shared.Communications;
using Robust.Client.UserInterface;
using Robust.Shared.Configuration;

namespace Content.Client._Local.Funny.UI
{
    public sealed class FunnyComputerBoundUserInterface : BoundUserInterface
    {
        [Dependency] private readonly IConfigurationManager _cfg = default!;

        [ViewVariables]
        private FunnyComputerMenu? _menu;

        private EntityUid? _owner;

        public FunnyComputerBoundUserInterface(EntityUid owner, Enum uiKey) : base(owner, uiKey)
        {
            _owner = owner;
        }

        protected override void Open()
        {
            base.Open();
            _menu = this.CreateWindow<FunnyComputerMenu>();
            _menu.SetEntity(Owner);
        }

        protected override void UpdateState(BoundUserInterfaceState state)
        {
            base.UpdateState(state);
        }
    }
}
