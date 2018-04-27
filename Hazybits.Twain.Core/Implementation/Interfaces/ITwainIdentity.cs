
namespace Hazybits.Twain.Core.Implementation.Interfaces
{
    public interface ITwainIdentity : ITwainStructure
    {
        uint Id { get; set; }
        ITwVersion Version { get; set; }
        ushort ProtocolMajor { get; set; }
        ushort ProtocolMinor { get; set; }
        uint SupportedGroups { get; set; }
        string Manufacturer { get; set; }
        string ProductFamily { get; set; }
        string ProductName { get; set; }
    }
}
