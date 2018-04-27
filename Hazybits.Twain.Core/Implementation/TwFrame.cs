using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.Implementation
{
    internal abstract class TwFrame<T> : TwainStructure<T>, ITwFrame
    {
		public abstract ITwFix32 Left { get; set; }
		public abstract ITwFix32 Top { get; set; }
		public abstract ITwFix32 Right { get; set; }
		public abstract ITwFix32 Bottom { get; set; }
	}
}
