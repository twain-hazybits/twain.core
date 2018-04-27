
namespace Hazybits.Twain.Core.Implementation
{
    internal abstract class TwPendingXFers<T> : TwainStructure<T>, Interfaces.ITwPendingXFers
    {
        public abstract ushort Count { get; set; }
        public abstract uint EOJ { get; set; }
    }
}
