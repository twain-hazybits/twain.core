using System;

namespace Hazybits.Twain.Core.Implementation.Interfaces
{
    public interface ITwainStructure
    {
		IntPtr GetStructurePtr();
	    void ReadStructureFromPtr(IntPtr ptr);
	}
}
