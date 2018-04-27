
namespace Hazybits.Twain.Core.Implementation.Interfaces
{
    public interface ITwPendingXFers : ITwainStructure
    {
        ushort Count { get; set; }
        uint EOJ { get; set; }
    }
}
