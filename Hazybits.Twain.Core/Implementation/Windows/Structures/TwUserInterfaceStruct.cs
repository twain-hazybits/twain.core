using System;
using System.Runtime.InteropServices;

namespace Hazybits.Twain.Core.Implementation.Windows.Structures
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    internal struct TwUserInterfaceStruct
    {
        public ushort ShowUI;
        public ushort ModalUI;
        public IntPtr hParent;
    }
}
