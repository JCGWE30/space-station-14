using Robust.Shared.Serialization;
using Robust.Shared.Utility;

namespace Content.Shared._Local.Funny
{
    [RegisterComponent]
    public partial class FunnyComputerComponent : Component
    {
        public float UIUpdateAccumulator = 0f;

        /// <summary>
        /// Remaining cooldown between making announcements.
        /// </summary>
        [ViewVariables]
        [DataField("funny")]
        public bool IsFunny;
    }

    [Serializable, NetSerializable]
    public sealed class FunnyComputerInterfaceState : BoundUserInterfaceState
    {
        public readonly bool IsFunny;

        public FunnyComputerInterfaceState(SpriteSpecifier.Texture selfTexture)
        {

        }
    }

    [Serializable, NetSerializable]
    public enum FunnyComputerInterface
    {
        Key
    }
}
