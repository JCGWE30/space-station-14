namespace Content.Server.Sound.Components;

[RegisterComponent]
public sealed partial class PlaySoundOnUseComponent: Component
{
    [DataField]
    public string Sound = string.Empty;
}
