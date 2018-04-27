using System;
using System.Runtime.InteropServices;

namespace Hazybits.Twain.Core.Implementation
{
    public class TwainStructure<T> : IDisposable
    {
        public T Structure;
        private IntPtr _ptr = IntPtr.Zero;

        public IntPtr GetStructurePtr()
        {
            if (_ptr == IntPtr.Zero)
                    _ptr = Marshal.AllocHGlobal(Marshal.SizeOf(typeof(T)));

            if (Structure != null)
                Marshal.StructureToPtr(Structure, _ptr, true);

            return _ptr;
        }

        public void ReadStructureFromPtr(IntPtr ptr)
        {
            Structure = (T)Marshal.PtrToStructure(ptr, typeof(T));
        }

        public void Dispose()
        {
            if (_ptr != IntPtr.Zero)
            {
                Marshal.FreeHGlobal(_ptr);
                _ptr = IntPtr.Zero;
            }
        }
    }
}
