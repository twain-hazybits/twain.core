using System;
using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.Implementation
{
    public class HandleDataImpl : ITwainStructure
    {
        public IntPtr Handle;
        public IntPtr GetStructurePtr()
        {
            return Handle;
        }

        public void ReadStructureFromPtr(IntPtr ptr)
        {
            Handle = ptr;
        }
    }
}
