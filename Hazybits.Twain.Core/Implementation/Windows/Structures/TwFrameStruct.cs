using System.Runtime.InteropServices;

namespace Hazybits.Twain.Core.Implementation.Windows.Structures
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    internal struct TwFrameStruct
    {
        public TwFix32Struct Left;
        public TwFix32Struct Top;
        public TwFix32Struct Right;
        public TwFix32Struct Bottom;
	}
}
