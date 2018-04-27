
namespace Hazybits.Twain.Core.Implementation
{
    internal abstract class TwVersion<T> : TwainStructure<T>, Implementation.Interfaces.ITwVersion
    {
        public abstract ushort MajorNum { get; set; }
        public abstract ushort MinorNum { get; set; }
        public abstract ushort Language { get; set; }
        public abstract ushort Country { get; set; }
        public abstract string Info { get; set; }
    }
}
