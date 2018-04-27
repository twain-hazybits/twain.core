using System;

namespace Hazybits.Twain.Core.Implementation.Interfaces
{
    internal interface IDsmWrapper : IDisposable
    {
        IntPtr MemoryAllocate(uint size);
        void FreeMemory(IntPtr ptr);
        IntPtr MemoryLock(IntPtr ptr);
        void MemoryUnlock(IntPtr ptr);

        ushort DSM_Entry(
            IntPtr pOrigin, // source of message
            IntPtr pDest,   // destination of message
            uint dg,             // data group ID: DG_xxxx
            ushort dat,          // data argument type: DAT_xxxx
            ushort msg,          // message ID: MSG_xxxx
            IntPtr pData         // pointer to data
        );
	}
}
