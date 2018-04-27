using System.Runtime.InteropServices;

namespace Hazybits.Twain.Core.Implementation.Windows.Structures
{
    [StructLayout(LayoutKind.Sequential, Pack = 2, CharSet = CharSet.Ansi)]
    internal struct TwVersionStruct
    {
        public ushort MajorNum;
        public ushort MinorNum;
        public ushort Language;
        public ushort Country;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 34)]
        public string Info;
    }
}
