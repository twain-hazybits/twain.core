using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.TwainStructures
{
    public class TwPendingXFers : TwainStructure<ITwPendingXFers>, ITwPendingXFers
	{
		public TwPendingXFers()
		{
			PlatformStructure = Implementation.FactoryImpl.CreateTwPendingXFers();
		}

		public ushort Count { get { return PlatformStructure.Count; } set { PlatformStructure.Count = value; } }
        public uint EOJ { get { return PlatformStructure.EOJ; } set { PlatformStructure.EOJ = value; } }
	}
}
