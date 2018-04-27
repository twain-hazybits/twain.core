using System;

namespace Hazybits.Twain.Core.Implementation.Interfaces
{
    public interface ITwEntrypoint : ITwainStructure
    {
        UInt32 Size { get; set; }
		IntPtr DSM_Entry { get; set; }
		IntPtr DSM_MemAllocate { get; set; }
		IntPtr DSM_MemFree { get; set; }
		IntPtr DSM_MemLock { get; set; }
		IntPtr DSM_MemUnlock { get; set; }
	}
}
