namespace Hazybits.Twain.Core.Implementation.Interfaces
{
    public interface ITwFrame : ITwainStructure
    {
        ITwFix32 Left { get; set; }
        ITwFix32 Top { get; set; }
        ITwFix32 Right { get; set; }
        ITwFix32 Bottom { get; set; }
    }
}
