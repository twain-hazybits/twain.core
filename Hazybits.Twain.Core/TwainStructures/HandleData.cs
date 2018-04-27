using System;
using Hazybits.Twain.Core.Implementation;
using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.TwainStructures
{
    public class HandleData : TwainStructure<HandleDataImpl>, ITwainStructure
	{
		public HandleData()
		{
			PlatformStructure = new HandleDataImpl();
		}

        public IntPtr Handle { get { return PlatformStructure.Handle; } set { PlatformStructure.Handle = value; } }
	}
}
