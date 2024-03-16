using Content.Shared.DeviceLinking;
using Content.Shared.DeviceLinking.Events;
using Robust.Shared.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.Server.Medical.AutoCare;
public sealed class AttunedBedSystem : EntitySystem
{
    public override void Initialize()
    {
        SubscribeLocalEvent<PatientComputerComponent, NewLinkEvent>(OnNewLink);
        SubscribeLocalEvent<PatientComputerComponent, PortDisconnectedEvent>(OnPortDisconnected);
    }

    private void OnNewLink(EntityUid uid, PatientComputerComponent component, NewLinkEvent args)
    {
        if (!TryComp<AttunedBedComponent>(args.Sink, out var bed))
            return;

        component.Bed = args.Sink;
        bed.Computer = uid;
    }

    private void OnPortDisconnected(EntityUid uid, PatientComputerComponent component, PortDisconnectedEvent args)
    {
        if (!TryComp<DeviceLinkSourceComponent>(uid, out var source) ||
            source.Ports == null)
            return;

        if (args.Port == source.Ports.First() && component.Bed != null)
        {
            if (TryComp<AttunedBedComponent>(component.Bed, out var bed))
                bed.Computer = null;
            component.Bed = null;
        }
    }
}
