using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Content.Server.Medical.AutoCare;

[RegisterComponent]
public sealed partial class AttunedBedComponent : Component
{
    [ViewVariables]
    public EntityUid? Computer;
}
