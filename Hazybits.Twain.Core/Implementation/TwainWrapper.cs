using System;
using System.Runtime.InteropServices;
using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.Implementation
{
	internal delegate IntPtr DsmMemoryAllocate(uint size);
	internal delegate void DsmMemoryFree(IntPtr handle);
	internal delegate IntPtr DsmMemoryLock(IntPtr handle);
	internal delegate void DsmMemoryUnlock(IntPtr handle);

	internal class TwainWrapper : IDsmWrapper
    {
        private IDsmWrapper _dsmWrapper;

		private DsmMemoryAllocate _memoryAllocate;
		private DsmMemoryFree _memoryFree;
		private DsmMemoryLock _memoryLock;
		private DsmMemoryUnlock _memoryUnlock;

		public TwainWrapper()
        {
			_dsmWrapper = FactoryImpl.CreateDsmWrapper();

			var entrypoints = new Hazybits.Twain.Core.TwainStructures.TwEntrypoint();
            var retCode = Dsm_Entry(null, null, (uint)DataGroup.Control, (ushort)DataArgumentType.EntryPoint, (ushort)Message.Get, entrypoints);
			if (retCode == (ushort)ReturnCode.Success)
			{
				if (entrypoints.DSM_MemAllocate != IntPtr.Zero)
					_memoryAllocate = Marshal.GetDelegateForFunctionPointer<DsmMemoryAllocate>(entrypoints.DSM_MemAllocate);
				if (entrypoints.DSM_MemFree != IntPtr.Zero)
					_memoryFree = Marshal.GetDelegateForFunctionPointer<DsmMemoryFree>(entrypoints.DSM_MemFree);
				if (entrypoints.DSM_MemLock != IntPtr.Zero)
					_memoryLock = Marshal.GetDelegateForFunctionPointer<DsmMemoryLock>(entrypoints.DSM_MemLock);
				if (entrypoints.DSM_MemUnlock != IntPtr.Zero)
					_memoryUnlock = Marshal.GetDelegateForFunctionPointer<DsmMemoryUnlock>(entrypoints.DSM_MemUnlock);
			}
		}

        public void Dispose()
        {
            if (_dsmWrapper != null)
			    _dsmWrapper.Dispose();
		}

		public IntPtr MemoryAllocate(uint size)
		{
			if (_memoryAllocate != null)
				return _memoryAllocate(size);

            return _dsmWrapper.MemoryAllocate(size);
		}

		public void FreeMemory(IntPtr ptr)
		{
            if (_memoryFree != null)
                _memoryFree(ptr);
            else
                _dsmWrapper.FreeMemory(ptr);

		}

		public IntPtr MemoryLock(IntPtr ptr)
		{
			if (_memoryLock != null)
				return _memoryLock(ptr);

            return _dsmWrapper.MemoryLock(ptr);
		}

		public void MemoryUnlock(IntPtr ptr)
		{
			if (_memoryUnlock != null)
				_memoryUnlock(ptr);
			else
                _dsmWrapper.MemoryUnlock(ptr);
		}

		public ushort DSM_Entry(
			IntPtr pOrigin, // source of message
			IntPtr pDest,   // destination of message
			uint dg,             // data group ID: DG_xxxx
			ushort dat,          // data argument type: DAT_xxxx
			ushort msg,          // message ID: MSG_xxxx
			IntPtr pData         // pointer to data
        )
        {
            return _dsmWrapper.DSM_Entry(pOrigin, pDest, dg, dat, msg, pData);
        }

		public ushort Dsm_Entry(
            ITwainIdentity pOrigin, // source of message
            ITwainIdentity pDest, // destination of message
            uint dg,             // data group ID: DG_xxxx
            ushort dat,          // data argument type: DAT_xxxx
            ushort msg,          // message ID: MSG_xxxx
            ITwainStructure dataStructureImpl // pointer to data
        )
        {
            //var sourcePtr = new IntPtr(global::System.Runtime.InteropServices.Marshal.SizeOf(((Windows.TwIdentityImpl)pOrigin).Identity));
            var sourcePtr = pOrigin == null ? IntPtr.Zero : pOrigin.GetStructurePtr();

            var destPtr = pDest == null ? IntPtr.Zero : pDest.GetStructurePtr();

            var pData = dataStructureImpl == null ? IntPtr.Zero : dataStructureImpl.GetStructurePtr();

            ushort retCode = 0;

            retCode = DSM_Entry(sourcePtr, destPtr, dg, dat, msg, pData);

            if (retCode == 0)
            {
                if (pOrigin != null)
                    pOrigin.ReadStructureFromPtr(sourcePtr);
                if (pDest != null)
                    pDest.ReadStructureFromPtr(destPtr);
                if (dataStructureImpl != null)
                    dataStructureImpl.ReadStructureFromPtr(pData);
            }

            return retCode;
        }
    }
}
