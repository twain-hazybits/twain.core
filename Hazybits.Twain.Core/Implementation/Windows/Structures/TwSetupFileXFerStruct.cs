using System;
using System.Runtime.InteropServices;

namespace Hazybits.Twain.Core.Implementation.Windows.Structures
{
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    internal struct TwSetupFileXFerStruct
    {
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 255)]
		public string FileName;
		public Int16 Format;
		public Int16 VRefNum;
	}
}
