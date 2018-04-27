using System;
using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.TwainStructures
{
    public class TwFix32 : TwainStructure<ITwFix32>, ITwFix32
    {
        public TwFix32()
        {
            PlatformStructure = Implementation.FactoryImpl.CreateTwFix32();
        }

        public TwFix32(ITwFix32 twFix32)
        {
            PlatformStructure = Implementation.FactoryImpl.CreateTwFix32();
            Whole = twFix32.Whole;
            Frac = twFix32.Frac;
        }
        
        public Int16 Whole { get { return PlatformStructure.Whole; } set { PlatformStructure.Whole = value; } }
        public UInt16 Frac { get { return PlatformStructure.Frac; } set { PlatformStructure.Frac = value; } }
	}
}
