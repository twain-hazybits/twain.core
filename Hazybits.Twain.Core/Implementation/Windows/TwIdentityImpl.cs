
namespace Hazybits.Twain.Core.Implementation.Windows
{
    internal class TwIdentityImpl : TwIdentity<Structures.TwIdentityStruct>
    {
        public override uint Id { get { return Structure.Id; } set { Structure.Id = value; } }
        public override Interfaces.ITwVersion Version {
			get { return new TwVersionImpl(Structure.Version); }
	        set { Structure.Version = new TwVersionImpl(value).Structure; }
		}
        public override ushort ProtocolMajor { get { return Structure.ProtocolMajor; } set { Structure.ProtocolMajor = value; } }
        public override ushort ProtocolMinor { get { return Structure.ProtocolMinor; } set { Structure.ProtocolMinor = value; } }
        public override uint SupportedGroups { get { return Structure.SupportedGroups; } set { Structure.SupportedGroups = value; } }
        public override string Manufacturer { get { return Structure.Manufacturer; } set { Structure.Manufacturer = value; } }
        public override string ProductFamily { get { return Structure.ProductFamily; } set { Structure.ProductFamily = value; } }
        public override string ProductName { get { return Structure.ProductName; } set { Structure.ProductName = value; } }
    }
}
