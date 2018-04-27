using System;

namespace Hazybits.Twain.Core.Implementation
{
    internal abstract class TwFix32<T> : TwainStructure<T>, Interfaces.ITwFix32
    {
		public abstract Int16 Whole { get; set; }
		public abstract UInt16 Frac { get; set; }
	}
}
