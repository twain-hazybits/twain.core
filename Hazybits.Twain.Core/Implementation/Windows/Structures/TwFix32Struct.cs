using System;
using System.Runtime.InteropServices;

namespace Hazybits.Twain.Core.Implementation.Windows.Structures
{
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	internal struct TwFix32Struct
    {
        public Int16 Whole;
        public UInt16 Frac;
	}
}
