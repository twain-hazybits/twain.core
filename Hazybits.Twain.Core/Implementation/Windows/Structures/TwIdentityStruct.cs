using System.Runtime.InteropServices;

namespace Hazybits.Twain.Core.Implementation.Windows.Structures
{
    [StructLayout(LayoutKind.Sequential, Pack = 2, CharSet = CharSet.Ansi)]
    internal struct TwIdentityStruct
    {
        public uint Id;
        public TwVersionStruct Version;
        public ushort ProtocolMajor;
        public ushort ProtocolMinor;
        public uint SupportedGroups;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 34)]
        public string Manufacturer;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 34)]
        public string ProductFamily;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 34)]
        public string ProductName;
    }
}
