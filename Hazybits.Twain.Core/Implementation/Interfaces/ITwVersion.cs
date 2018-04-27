
namespace Hazybits.Twain.Core.Implementation.Interfaces
{
    public interface ITwVersion : ITwainStructure
    {
        ushort MajorNum { get; set; }
        ushort MinorNum { get; set; }
        // todo: replace with Language enum.
        ushort Language { get; set; }
        // todo: replace with Country enum.
        ushort Country { get; set; }
        string Info { get; set; }
    }
}
