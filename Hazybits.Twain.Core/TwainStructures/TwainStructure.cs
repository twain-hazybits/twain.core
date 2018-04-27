using System;
using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.TwainStructures
{
	public abstract class TwainStructure<T> where T: ITwainStructure
	{
		protected T PlatformStructure { get; set; }


		public virtual IntPtr GetStructurePtr()
		{
            return PlatformStructure.GetStructurePtr();
		}

		public virtual void ReadStructureFromPtr(IntPtr ptr)
		{
			PlatformStructure.ReadStructureFromPtr(ptr);
		}
	}
}
