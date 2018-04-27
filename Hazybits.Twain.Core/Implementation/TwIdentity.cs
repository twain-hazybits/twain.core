
namespace Hazybits.Twain.Core.Implementation
{
    internal abstract class TwIdentity<T> : TwainStructure<T>, Interfaces.ITwainIdentity
    {
        public abstract uint Id { get; set; }
        public abstract Interfaces.ITwVersion Version { get; set; }
        public abstract ushort ProtocolMajor { get; set; }
        public abstract ushort ProtocolMinor { get; set; }
        public abstract uint SupportedGroups { get; set; }
        public abstract string Manufacturer { get; set; }
        public abstract string ProductFamily { get; set; }
        public abstract string ProductName { get; set; }
    }
}
