using System;
using System.Runtime.InteropServices;

namespace Hazybits.Twain.Core.Implementation.Windows.Structures
{
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	internal struct TwEntrypointStruct
	{
		public UInt32 Size;
		public IntPtr DSM_Entry;
		public IntPtr DSM_MemAllocate;
		public IntPtr DSM_MemFree;
		public IntPtr DSM_MemLock;
		public IntPtr DSM_MemUnlock;
	}
}
