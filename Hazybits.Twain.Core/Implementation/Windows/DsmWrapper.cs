using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace Hazybits.Twain.Core.Implementation.Windows
{
    internal class DsmWrapper : Interfaces.IDsmWrapper
    {
        private static IntPtr _dsmLibrary = IntPtr.Zero;

        private bool useV1 = false;

        public DsmWrapper()
        {
            string libpath;

            if (useV1)
            {
                var path = GetWindowsPath();
                if (path == null) return;
                libpath = Path.Combine(path, "twain_32.dll");
            }
            else
            {
                var path = Environment.GetFolderPath(Environment.SpecialFolder.System);
                libpath = Path.Combine(path, "twaindsm.dll");
            }

            _dsmLibrary = LoadLibrary(libpath);
        }

        public void Dispose()
        {
            if (_dsmLibrary != IntPtr.Zero)
            {
                FreeLibrary(_dsmLibrary);
                _dsmLibrary = IntPtr.Zero;
            }
        }

        public IntPtr MemoryAllocate(uint size)
        {
            return GlobalAlloc(size, (UIntPtr)0x0042 /* GHND */);
        }

        public void FreeMemory(IntPtr ptr)
        {
            GlobalFree(ptr);
        }

        public IntPtr MemoryLock(IntPtr ptr)
        {
            return GlobalLock(ptr);
        }

        public void MemoryUnlock(IntPtr ptr)
        {
            GlobalUnlock(ptr);
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
            if (useV1)
                return DSM_Entry_Win_v1(pOrigin, pDest, dg, dat, msg, pData);

            return DSM_Entry_Win_v2(pOrigin, pDest, dg, dat, msg, pData);
        }

		[DllImport("kernel32.dll", EntryPoint = "LoadLibrary")]
        private static extern IntPtr LoadLibrary(string filename);

        [DllImport("kernel32.dll", EntryPoint = "FreeLibrary")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeLibrary(IntPtr module);

        [DllImport("kernel32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        private static extern uint GetWindowsDirectory([MarshalAs(UnmanagedType.LPTStr)]StringBuilder lpBuffer, uint uSize);

		[DllImport("kernel32.dll")]
		private static extern IntPtr GlobalAlloc(uint uFlags, UIntPtr dwBytes);

		[DllImport("kernel32.dll")]
		private static extern IntPtr GlobalFree(IntPtr hMem);

		[DllImport("kernel32.dll")]
		private static extern IntPtr GlobalLock(IntPtr hMem);

		[DllImport("kernel32.dll")]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool GlobalUnlock(IntPtr hMem);

		private static string GetWindowsPath()
        {
            var path = new StringBuilder(256); // MAX_PATH
            var size = GetWindowsDirectory(path, 256);
            if (size > 0)
                return path.ToString(0, (int)size);

            return null;
        }

        [DllImport("twain_32.dll", EntryPoint = "DSM_Entry")]
        private static extern ushort DSM_Entry_Win_v1(
            IntPtr pOrigin, // source of message
            IntPtr pDest,   // destination of message
            uint dg,             // data group ID: DG_xxxx
            ushort dat,          // data argument type: DAT_xxxx
            ushort msg,          // message ID: MSG_xxxx
            IntPtr pData         // pointer to data
        );

        [DllImport("twaindsm.dll", EntryPoint = "DSM_Entry")]
        private static extern ushort DSM_Entry_Win_v2(
            IntPtr pOrigin, // source of message
            IntPtr pDest,   // destination of message
            uint dg,             // data group ID: DG_xxxx
            ushort dat,          // data argument type: DAT_xxxx
            ushort msg,          // message ID: MSG_xxxx
            IntPtr pData         // pointer to data
        );
    }
}
