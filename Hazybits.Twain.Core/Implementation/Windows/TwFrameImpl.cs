using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.Implementation.Windows
{
    internal class TwFrameImpl : TwFrame<Structures.TwFrameStruct>
    {
        public override ITwFix32 Left { get { return new TwFix32Impl(Structure.Left); } set { Structure.Left = new TwFix32Impl(value).Structure; } }
        public override ITwFix32 Top { get { return new TwFix32Impl(Structure.Top); } set { Structure.Top = new TwFix32Impl(value).Structure; } }
        public override ITwFix32 Right { get { return new TwFix32Impl(Structure.Right); } set { Structure.Right = new TwFix32Impl(value).Structure; } }
        public override ITwFix32 Bottom { get { return new TwFix32Impl(Structure.Bottom); } set { Structure.Bottom = new TwFix32Impl(value).Structure; } }
	}
}
