using System;

namespace Hazybits.Twain.Core.Constants
{
    [Flags]
    public enum TwQC : ushort
    {
        Get           = 0x0001,
        Set           = 0x0002,
        GetDefault    = 0x0004,
        GetCurrent    = 0x0008,
        Reset         = 0x0010,
        SetConstraint = 0x0020,
        Constrainable = 0x0040,
        GetHelp       = 0x0100,
        GetLabel      = 0x0200,
        GetLabelNum   = 0x0400
    }
}
