using Content.Server.Sound.Components;
using Content.Shared.Interaction.Events;
using Content.Shared.Timing;
using Robust.Shared.Audio.Systems;

namespace Content.Server.Sound;

public sealed class PlaySoundOnUseSystem : EntitySystem
{
    [Dependency] private readonly SharedAudioSystem _audio = default!;
    [Dependency] private readonly UseDelaySystem _useDelay = default!;

    public override void Initialize()
    {
        SubscribeLocalEvent<PlaySoundOnUseComponent, UseInHandEvent>(OnUseInHand);
    }
    private void OnUseInHand(EntityUid uid, PlaySoundOnUseComponent comp, UseInHandEvent args)
    {
        if (!TryComp(uid, out UseDelayComponent? useDelay)
            // if on cooldown, do nothing
            // and set cooldown to prevent clocks
            || !_useDelay.TryResetDelay((uid, useDelay), true))
            return;
        _audio.PlayPvs(comp.Sound, uid);
    }
}
