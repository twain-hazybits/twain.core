using System;

namespace Hazybits.Twain.Core.Implementation.Windows
{
    internal class TwEntrypointImpl : TwEntrypoint<Structures.TwEntrypointStruct>
    {
		public override UInt32 Size { get { return Structure.Size; } set { Structure.Size = value; } }
		public override IntPtr DSM_Entry { get { return Structure.DSM_Entry; } set { Structure.DSM_Entry = value; } }
		public override IntPtr DSM_MemAllocate { get { return Structure.DSM_MemAllocate; } set { Structure.DSM_MemAllocate = value; } }
		public override IntPtr DSM_MemFree { get { return Structure.DSM_MemFree; } set { Structure.DSM_MemFree = value; } }
		public override IntPtr DSM_MemLock { get { return Structure.DSM_MemLock; } set { Structure.DSM_MemLock = value; } }
		public override IntPtr DSM_MemUnlock { get { return Structure.DSM_MemUnlock; } set { Structure.DSM_MemUnlock = value; } }
	}
}
