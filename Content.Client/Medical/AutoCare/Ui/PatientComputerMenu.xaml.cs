using Content.Client.UserInterface.Controls;
using Robust.Client.UserInterface.XAML;
using Robust.Client.AutoGenerated;

namespace Content.Client.Medical.AutoCare.Ui;

[GenerateTypedNameReferences]
public sealed partial class PatientComputerMenu : FancyWindow
{
    private PatientComputerBoundUserInterface Owner { get; set; }

    public PatientComputerMenu(PatientComputerBoundUserInterface owner)
    {
        RobustXamlLoader.Load(this);

        Owner = owner;

        var loc = IoCManager.Resolve<ILocalizationManager>();
        Button.OnPressed += (_) => Owner.pressButton();
        Button.Disabled = !owner.ClickedButton;
    }

    public override void Close()
    {
        base.Close();
    }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
    }
}
}
