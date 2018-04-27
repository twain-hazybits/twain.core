using System;

namespace Hazybits.Twain.Core.Implementation
{
    internal abstract class TwEntrypoint<T> : TwainStructure<T>, Interfaces.ITwEntrypoint
    {
        public abstract UInt32 Size { get; set; }
        public abstract IntPtr DSM_Entry { get; set; }
        public abstract IntPtr DSM_MemAllocate { get; set; }
        public abstract IntPtr DSM_MemFree { get; set; }
        public abstract IntPtr DSM_MemLock { get; set; }
        public abstract IntPtr DSM_MemUnlock { get; set; }
    }
}
