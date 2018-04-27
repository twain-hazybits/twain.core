using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.TwainStructures
{
    public class TwFrame : TwainStructure<ITwFrame>, ITwFrame
    {
        public TwFrame()
        {
            PlatformStructure = Implementation.FactoryImpl.CreateTwFrame();
        }

        public ITwFix32 Left { get { return new TwFix32(PlatformStructure.Left); } set { PlatformStructure.Left = value; } }
        public ITwFix32 Top { get { return new TwFix32(PlatformStructure.Top); } set { PlatformStructure.Top = value; } }
        public ITwFix32 Right { get { return new TwFix32(PlatformStructure.Right); } set { PlatformStructure.Right = value; } }
        public ITwFix32 Bottom { get { return new TwFix32(PlatformStructure.Bottom); } set { PlatformStructure.Bottom = value; } }
	}
}
