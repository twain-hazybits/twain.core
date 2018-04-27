using System;
using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.TwainStructures
{
    public class TwEntrypoint : TwainStructure<ITwEntrypoint>, ITwEntrypoint
    {
        public TwEntrypoint()
        {
            PlatformStructure = Implementation.FactoryImpl.CreateTwEntryPoint();
        }

        public uint Size { get { return PlatformStructure.Size; } set { PlatformStructure.Size = value; } }
        public IntPtr DSM_Entry { get { return PlatformStructure.DSM_Entry; } set { PlatformStructure.DSM_Entry = value; } }
        public IntPtr DSM_MemAllocate { get { return PlatformStructure.DSM_MemAllocate; } set { PlatformStructure.DSM_MemAllocate = value; } }
        public IntPtr DSM_MemFree { get { return PlatformStructure.DSM_MemFree; } set { PlatformStructure.DSM_MemFree = value; } }
        public IntPtr DSM_MemLock { get { return PlatformStructure.DSM_MemLock; } set { PlatformStructure.DSM_MemLock = value; } }
        public IntPtr DSM_MemUnlock { get { return PlatformStructure.DSM_MemUnlock; } set { PlatformStructure.DSM_MemUnlock = value; } }
	}
}
