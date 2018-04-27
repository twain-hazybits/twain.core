using System;
using System.Runtime.InteropServices;

namespace Hazybits.Twain.Core.Implementation.Windows.Structures
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    internal struct TwOneValueStruct
    {
        public ItemType ItemType;
        public IntPtr Item;
    }
}
