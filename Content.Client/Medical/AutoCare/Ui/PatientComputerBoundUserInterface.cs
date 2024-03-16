using Content.Shared.Xenoarchaeology.Equipment;
using JetBrains.Annotations;
using Robust.Client.GameObjects;

namespace Content.Client.Medical.AutoCare.Ui;

public sealed class PatientComputerBoundUserInterface : BoundUserInterface
{
    [ViewVariables]
    private PatientComputerMenu? _menu;
    [ViewVariables]
    public bool ClickedButton { get; private set; }

    public PatientComputerBoundUserInterface(EntityUid owner, Enum uiKey) : base(owner, uiKey)
    {
    }

    protected override void Open()
    {
        base.Open();

        _menu = new PatientComputerMenu(this);
        _menu.OnClose += Close;
        _menu.OpenCentered();
    }
    public void pressButton()
    {
        ClickedButton = true;
    }

    protected override void Dispose(bool disposing)
    {
        base.Dispose(disposing);
        if (!disposing) return;

        _menu?.Dispose();
    }
}
}

