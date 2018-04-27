using System;
using System.Runtime.InteropServices;

namespace Hazybits.Twain.Core.Implementation.Windows.Structures
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    internal struct TwCapabilityStruct
    {
        public Capability Capability;
        public ContainerType ContainerType;
        public IntPtr Container;
	}
}
