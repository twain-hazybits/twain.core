using System.Runtime.InteropServices;

namespace Hazybits.Twain.Core.Implementation.Windows.Structures
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    internal struct TwPendingXFersStruct
    {
        public ushort Count;
        public uint EOJ;
    }
}
