using System;
namespace Hazybits.Twain.Core.Implementation.Interfaces
{
    public interface ITwFix32 : ITwainStructure
    {
        Int16 Whole { get; set; }
        UInt16 Frac { get; set; }
	}
}
