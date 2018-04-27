using System;
using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.Implementation.Windows
{
    internal class TwFix32Impl : TwFix32<Structures.TwFix32Struct>
    {
        public TwFix32Impl() {}

        public TwFix32Impl(Structures.TwFix32Struct twFix32Struct)
        {
			Structure.Whole = twFix32Struct.Whole;
			Structure.Frac = twFix32Struct.Frac;
		}

        public TwFix32Impl(ITwFix32 twFix32Struct)
        {
            Structure.Whole = twFix32Struct.Whole;
            Structure.Frac = twFix32Struct.Frac;
        }
        
        public override Int16 Whole { get { return Structure.Whole; } set { Structure.Whole = value; } }
        public override UInt16 Frac { get { return Structure.Frac; } set { Structure.Frac = value; } }
	}
}
