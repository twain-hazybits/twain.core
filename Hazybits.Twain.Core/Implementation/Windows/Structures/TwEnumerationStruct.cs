using System;
using System.Runtime.InteropServices;

namespace Hazybits.Twain.Core.Implementation.Windows.Structures
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    internal struct TwEnumerationStruct
    {
        public ItemType ItemType;
        public uint NumItems;
        public uint CurrentIndex;
        public uint DefaultIndex;
        //public byte[] ItemList;
        public IntPtr Items;
    }
}
