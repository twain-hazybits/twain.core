using Hazybits.Twain.Core.Implementation.Interfaces;

namespace Hazybits.Twain.Core.TwainStructures
{
    public class TwIdentity : TwainStructure<ITwainIdentity>, ITwainIdentity
	{
		public TwIdentity()
		{
			PlatformStructure = Implementation.FactoryImpl.CreateTwainIdentity();
		}

		public uint Id { get { return PlatformStructure.Id; } set { PlatformStructure.Id = value; } }

        public ITwVersion Version
        {
            get
            {
                return new TwVersion(PlatformStructure.Version);
            }
            set
            {
	            PlatformStructure.Version = value; 
            }
        }

        public ushort ProtocolMajor { get { return PlatformStructure.ProtocolMajor; } set { PlatformStructure.ProtocolMajor = value; } }
        public ushort ProtocolMinor { get { return PlatformStructure.ProtocolMinor; } set { PlatformStructure.ProtocolMinor = value; } }
        public uint SupportedGroups { get { return PlatformStructure.SupportedGroups; } set { PlatformStructure.SupportedGroups = value; } }
        public string Manufacturer { get { return PlatformStructure.Manufacturer; } set { PlatformStructure.Manufacturer = value; } }
        public string ProductFamily { get { return PlatformStructure.ProductFamily; } set { PlatformStructure.ProductFamily = value; } }
        public string ProductName { get { return PlatformStructure.ProductName; } set { PlatformStructure.ProductName = value; } }
	}
}
