using System;

namespace Hazybits.Twain.Core
{
    [Flags]
    public enum DataGroup
    {
        Control  = 1,
        Image    = 2,
        Audio    = 4,

        DfDsm2 = 0x10000000,
        DfApp2 = 0x20000000,
        DfDs2 = 0x40000000,
        Mask = 0xFFFF

    }
}
